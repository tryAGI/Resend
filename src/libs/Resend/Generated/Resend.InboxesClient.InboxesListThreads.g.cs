
#nullable enable

namespace Resend
{
    public partial class InboxesClient
    {


        private static readonly global::Resend.EndPointSecurityRequirement s_InboxesListThreadsSecurityRequirement0 =
            new global::Resend.EndPointSecurityRequirement
            {
                Authorizations = new global::Resend.EndPointAuthorizationRequirement[]
                {                    new global::Resend.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Resend.EndPointSecurityRequirement[] s_InboxesListThreadsSecurityRequirements =
            new global::Resend.EndPointSecurityRequirement[]
            {                s_InboxesListThreadsSecurityRequirement0,
            };
        partial void PrepareInboxesListThreadsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders,
            global::System.Collections.Generic.IList<global::System.Guid>? labels,
            ref bool? read,
            ref int? limit,
            ref string? after,
            ref string? before);
        partial void PrepareInboxesListThreadsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders,
            global::System.Collections.Generic.IList<global::System.Guid>? labels,
            bool? read,
            int? limit,
            string? after,
            string? before);
        partial void ProcessInboxesListThreadsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInboxesListThreadsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve a list of inbox threads<br/>
        /// Returns the threads in an inbox, most recently active first. A thread is a conversation made up of one or more emails. The `after` and `before` cursors take a thread ID, and only one of them can be passed. A cursor that is not a UUID, such as a date, returns a 422 validation_error. A cursor thread that is not in the selected folders returns a 404. To find threads by text, sender, recipient, attachment, or date, use the search threads endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.ListInboxThreadsResponseSuccess> InboxesListThreadsAsync(
            string inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InboxesListThreadsAsResponseAsync(
                inboxId: inboxId,
                folders: folders,
                labels: labels,
                read: read,
                limit: limit,
                after: after,
                before: before,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Retrieve a list of inbox threads<br/>
        /// Returns the threads in an inbox, most recently active first. A thread is a conversation made up of one or more emails. The `after` and `before` cursors take a thread ID, and only one of them can be passed. A cursor that is not a UUID, such as a date, returns a 422 validation_error. A cursor thread that is not in the selected folders returns a 404. To find threads by text, sender, recipient, attachment, or date, use the search threads endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxThreadsResponseSuccess>> InboxesListThreadsAsResponseAsync(
            string inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareInboxesListThreadsArguments(
                httpClient: HttpClient,
                inboxId: ref inboxId,
                folders: folders,
                labels: labels,
                read: ref read,
                limit: ref limit,
                after: ref after,
                before: ref before);


            var __authorizations = global::Resend.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InboxesListThreadsSecurityRequirements,
                operationName: "InboxesListThreadsAsync");

            using var __timeoutCancellationTokenSource = global::Resend.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Resend.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Resend.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Resend.PathBuilder(
                                path: $"/inboxes/{inboxId}/threads",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("folders", folders, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("labels", labels, selector: static x => x.ToString() ?? throw new global::System.InvalidOperationException("A required query parameter returned null from ToString()."), delimiter: ",", explode: false)
                                .AddOptionalParameter("read", read?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("before", before)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Resend.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::Resend.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareInboxesListThreadsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    inboxId: inboxId,
                    folders: folders,
                    labels: labels,
                    read: read,
                    limit: limit,
                    after: after,
                    before: before);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Resend.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesListThreads",
                                methodName: "InboxesListThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Resend.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Resend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesListThreads",
                                methodName: "InboxesListThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Resend.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Resend.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Resend.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Resend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesListThreads",
                                methodName: "InboxesListThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Resend.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessInboxesListThreadsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Resend.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesListThreads",
                                methodName: "InboxesListThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Resend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesListThreads",
                                methodName: "InboxesListThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessInboxesListThreadsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Resend.ListInboxThreadsResponseSuccess.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxThreadsResponseSuccess>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Resend.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Resend.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Resend.ListInboxThreadsResponseSuccess.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxThreadsResponseSuccess>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Resend.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Resend.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}