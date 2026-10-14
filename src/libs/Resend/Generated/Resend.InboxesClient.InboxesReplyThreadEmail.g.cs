
#nullable enable

namespace Resend
{
    public partial class InboxesClient
    {


        private static readonly global::Resend.EndPointSecurityRequirement s_InboxesReplyThreadEmailSecurityRequirement0 =
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
        private static readonly global::Resend.EndPointSecurityRequirement[] s_InboxesReplyThreadEmailSecurityRequirements =
            new global::Resend.EndPointSecurityRequirement[]
            {                s_InboxesReplyThreadEmailSecurityRequirement0,
            };
        partial void PrepareInboxesReplyThreadEmailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? idempotencyKey,
            ref global::System.Guid inboxId,
            ref global::System.Guid threadId,
            ref global::System.Guid emailId,
            global::Resend.ReplyInboxThreadEmailOptions request);
        partial void PrepareInboxesReplyThreadEmailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? idempotencyKey,
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,
            global::Resend.ReplyInboxThreadEmailOptions request);
        partial void ProcessInboxesReplyThreadEmailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInboxesReplyThreadEmailResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.ReplyInboxThreadEmailResponseSuccess> InboxesReplyThreadEmailAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ReplyInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InboxesReplyThreadEmailAsResponseAsync(
                inboxId: inboxId,
                threadId: threadId,
                emailId: emailId,

                request: request,
                idempotencyKey: idempotencyKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ReplyInboxThreadEmailResponseSuccess>> InboxesReplyThreadEmailAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ReplyInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInboxesReplyThreadEmailArguments(
                httpClient: HttpClient,
                idempotencyKey: ref idempotencyKey,
                inboxId: ref inboxId,
                threadId: ref threadId,
                emailId: ref emailId,
                request: request);


            var __authorizations = global::Resend.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InboxesReplyThreadEmailSecurityRequirements,
                operationName: "InboxesReplyThreadEmailAsync");

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
                                path: $"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Resend.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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

            var __idempotencyKey = global::System.String.IsNullOrWhiteSpace(idempotencyKey)
                ? CreateIdempotencyKey()
                : idempotencyKey;
            __httpRequest.Headers.TryAddWithoutValidation("Idempotency-Key", __idempotencyKey);

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Resend.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareInboxesReplyThreadEmailRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    idempotencyKey: idempotencyKey,
                    inboxId: inboxId,
                    threadId: threadId,
                    emailId: emailId,
                    request: request);

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
                                operationId: "InboxesReplyThreadEmail",
                                methodName: "InboxesReplyThreadEmailAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply\"",
                                httpMethod: "POST",
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
                                operationId: "InboxesReplyThreadEmail",
                                methodName: "InboxesReplyThreadEmailAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply\"",
                                httpMethod: "POST",
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
                                operationId: "InboxesReplyThreadEmail",
                                methodName: "InboxesReplyThreadEmailAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply\"",
                                httpMethod: "POST",
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
                ProcessInboxesReplyThreadEmailResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Resend.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Resend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InboxesReplyThreadEmail",
                                methodName: "InboxesReplyThreadEmailAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply\"",
                                httpMethod: "POST",
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
                                operationId: "InboxesReplyThreadEmail",
                                methodName: "InboxesReplyThreadEmailAsync",
                                pathTemplate: "$\"/inboxes/{inboxId}/threads/{threadId}/emails/{emailId}/reply\"",
                                httpMethod: "POST",
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
                                ProcessInboxesReplyThreadEmailResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Resend.ReplyInboxThreadEmailResponseSuccess.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.ReplyInboxThreadEmailResponseSuccess>(
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

                                    var __value = await global::Resend.ReplyInboxThreadEmailResponseSuccess.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Resend.AutoSDKHttpResponse<global::Resend.ReplyInboxThreadEmailResponseSuccess>(
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
        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="cc">
        /// CC recipient email address. For multiple addresses, send as an array of strings. Without `reply_all`, the reply copies only these addresses. With `reply_all`, these addresses are merged with the copied recipients, without duplicates. `cc` and `bcc` combined must be fewer than 50 addresses. After the `to` recipients are added, the reply cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </param>
        /// <param name="bcc">
        /// BCC recipient email address. For multiple addresses, send as an array of strings. BCC recipients of the original message are never copied. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </param>
        /// <param name="html">
        /// The HTML body of the reply.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain-text body of the reply.<br/>
        /// Example: Refund issued for order 1041.
        /// </param>
        /// <param name="subject">
        /// The subject of the reply. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Re:` if it does not already start with it.<br/>
        /// Example: Re: Refund for order 1041
        /// </param>
        /// <param name="replyAll">
        /// Reply to everyone on the original message. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has none, and copies the other addresses of its `To` header and its `cc` recipients in `cc`. For a message the inbox sent, the reply goes to that message's `Reply-To` addresses when they are not the inbox address, otherwise to its `to` recipients, and copies its `cc` recipients. The inbox address is always excluded, and duplicates are removed.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="attachments">
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. Up to 10 files. The `content` of all files can total at most 25 MB. A `path` file counts toward the 10 files only, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that is not an `http` or `https` URL or that points to `localhost`, `127.0.0.1` or `0.0.0.0`, or a `content_type` that is not a valid MIME type returns a 422.
        /// </param>
        /// <param name="headers">
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.ReplyInboxThreadEmailResponseSuccess> InboxesReplyThreadEmailAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            string? html = default,
            string? text = default,
            string? subject = default,
            bool? replyAll = default,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Resend.ReplyInboxThreadEmailOptions
            {
                Cc = cc,
                Bcc = bcc,
                Html = html,
                Text = text,
                Subject = subject,
                ReplyAll = replyAll,
                Attachments = attachments,
                Headers = headers,
            };

            return await InboxesReplyThreadEmailAsync(
                idempotencyKey: idempotencyKey,
                inboxId: inboxId,
                threadId: threadId,
                emailId: emailId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}