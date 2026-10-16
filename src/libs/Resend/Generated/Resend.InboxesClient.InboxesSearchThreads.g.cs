
#nullable enable

namespace Resend
{
    public partial class InboxesClient
    {


        private static readonly global::Resend.EndPointSecurityRequirement s_InboxesSearchThreadsSecurityRequirement0 =
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
        private static readonly global::Resend.EndPointSecurityRequirement[] s_InboxesSearchThreadsSecurityRequirements =
            new global::Resend.EndPointSecurityRequirement[]
            {                s_InboxesSearchThreadsSecurityRequirement0,
            };
        partial void PrepareInboxesSearchThreadsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string inboxId,
            ref string? query,
            global::System.Collections.Generic.IList<string>? from,
            global::System.Collections.Generic.IList<string>? to,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? bcc,
            ref bool? hasAttachment,
            ref string? startDate,
            ref string? endDate,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders,
            global::System.Collections.Generic.IList<global::System.Guid>? labels,
            ref bool? read,
            ref int? limit,
            ref string? after,
            ref string? before);
        partial void PrepareInboxesSearchThreadsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string inboxId,
            string? query,
            global::System.Collections.Generic.IList<string>? from,
            global::System.Collections.Generic.IList<string>? to,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? bcc,
            bool? hasAttachment,
            string? startDate,
            string? endDate,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders,
            global::System.Collections.Generic.IList<global::System.Guid>? labels,
            bool? read,
            int? limit,
            string? after,
            string? before);
        partial void ProcessInboxesSearchThreadsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInboxesSearchThreadsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search the threads of an inbox<br/>
        /// Finds threads by the text of their emails, who sent or received them, whether they have attachments, and their dates. Results are ordered by latest activity, newest first, and paginate like the list threads endpoint, so a cursor that is not a thread ID returns a 422. Search can be up to about a minute behind new emails. Different parameters combine, so a thread must match all of them. `folders`, `labels`, and `read` apply to the thread. `query`, `from`, `to`, `cc`, `bcc`, `has_attachment`, `start_date`, and `end_date` must all match the same email in the thread. When any of these email filters is set, the matching email must itself be in one of `folders`. For `sent`, that means an email the inbox sent. When more than 10,000 threads match, search covers the 10,000 with the newest matching email.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="query"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="hasAttachment"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.SearchInboxThreadsResponseSuccess> InboxesSearchThreadsAsync(
            string inboxId,
            string? query = default,
            global::System.Collections.Generic.IList<string>? from = default,
            global::System.Collections.Generic.IList<string>? to = default,
            global::System.Collections.Generic.IList<string>? cc = default,
            global::System.Collections.Generic.IList<string>? bcc = default,
            bool? hasAttachment = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InboxesSearchThreadsAsResponseAsync(
                inboxId: inboxId,
                query: query,
                from: from,
                to: to,
                cc: cc,
                bcc: bcc,
                hasAttachment: hasAttachment,
                startDate: startDate,
                endDate: endDate,
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
        /// Search the threads of an inbox<br/>
        /// Finds threads by the text of their emails, who sent or received them, whether they have attachments, and their dates. Results are ordered by latest activity, newest first, and paginate like the list threads endpoint, so a cursor that is not a thread ID returns a 422. Search can be up to about a minute behind new emails. Different parameters combine, so a thread must match all of them. `folders`, `labels`, and `read` apply to the thread. `query`, `from`, `to`, `cc`, `bcc`, `has_attachment`, `start_date`, and `end_date` must all match the same email in the thread. When any of these email filters is set, the matching email must itself be in one of `folders`. For `sent`, that means an email the inbox sent. When more than 10,000 threads match, search covers the 10,000 with the newest matching email.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="query"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="hasAttachment"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.SearchInboxThreadsResponseSuccess>> InboxesSearchThreadsAsResponseAsync(
            string inboxId,
            string? query = default,
            global::System.Collections.Generic.IList<string>? from = default,
            global::System.Collections.Generic.IList<string>? to = default,
            global::System.Collections.Generic.IList<string>? cc = default,
            global::System.Collections.Generic.IList<string>? bcc = default,
            bool? hasAttachment = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders = default,
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
            PrepareInboxesSearchThreadsArguments(
                httpClient: HttpClient,
                inboxId: ref inboxId,
                query: ref query,
                from: from,
                to: to,
                cc: cc,
                bcc: bcc,
                hasAttachment: ref hasAttachment,
                startDate: ref startDate,
                endDate: ref endDate,
                folders: folders,
                labels: labels,
                read: ref read,
                limit: ref limit,
                after: ref after,
                before: ref before);


            var __authorizations = global::Resend.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InboxesSearchThreadsSecurityRequirements,
                operationName: "InboxesSearchThreadsAsync");

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
                                path: $"/inboxes/{inboxId}/threads/search",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("query", query)
                                .AddOptionalParameter("from", from, delimiter: ",", explode: false)
                                .AddOptionalParameter("to", to, delimiter: ",", explode: false)
                                .AddOptionalParameter("cc", cc, delimiter: ",", explode: false)
                                .AddOptionalParameter("bcc", bcc, delimiter: ",", explode: false)
                                .AddOptionalParameter("has_attachment", hasAttachment?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("start_date", startDate)
                                .AddOptionalParameter("end_date", endDate)
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
                PrepareInboxesSearchThreadsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    inboxId: inboxId,
                    query: query,
                    from: from,
                    to: to,
                    cc: cc,
                    bcc: bcc,
                    hasAttachment: hasAttachment,
                    startDate: startDate,
                    endDate: endDate,
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
                                operationId: "InboxesSearchThreads",
                                methodName: "InboxesSearchThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/search\"",
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
                                operationId: "InboxesSearchThreads",
                                methodName: "InboxesSearchThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/search\"",
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
                                operationId: "InboxesSearchThreads",
                                methodName: "InboxesSearchThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/search\"",
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
                ProcessInboxesSearchThreadsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Resend.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesSearchThreads",
                                methodName: "InboxesSearchThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/search\"",
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
                                operationId: "InboxesSearchThreads",
                                methodName: "InboxesSearchThreadsAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/search\"",
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
                                ProcessInboxesSearchThreadsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Resend.SearchInboxThreadsResponseSuccess.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.SearchInboxThreadsResponseSuccess>(
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

                                    var __value = await global::Resend.SearchInboxThreadsResponseSuccess.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.SearchInboxThreadsResponseSuccess>(
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