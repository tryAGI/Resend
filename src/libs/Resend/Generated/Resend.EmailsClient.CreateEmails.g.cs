
#nullable enable

namespace Resend
{
    public partial class EmailsClient
    {
        partial void PrepareCreateEmailsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? idempotencyKey,
            global::Resend.SendEmailRequest request);
        partial void PrepareCreateEmailsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? idempotencyKey,
            global::Resend.SendEmailRequest request);
        partial void ProcessCreateEmailsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEmailsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="idempotencyKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.SendEmailResponse> CreateEmailsAsync(

            global::Resend.SendEmailRequest request,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateEmailsArguments(
                httpClient: HttpClient,
                idempotencyKey: ref idempotencyKey,
                request: request);

            var __pathBuilder = new global::Resend.PathBuilder(
                path: "/emails",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            if (idempotencyKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Idempotency-Key", idempotencyKey.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateEmailsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                idempotencyKey: idempotencyKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateEmailsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateEmailsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Resend.SendEmailResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Resend.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Resend.SendEmailResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Resend.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="idempotencyKey"></param>
        /// <param name="from">
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </param>
        /// <param name="to">
        /// Recipient email address. For multiple addresses, send as an array of strings. Max 50.
        /// </param>
        /// <param name="subject">
        /// Email subject.
        /// </param>
        /// <param name="bcc">
        /// Bcc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="cc">
        /// Cc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="replyTo">
        /// Reply-to email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="html">
        /// The HTML version of the message.
        /// </param>
        /// <param name="text">
        /// The plain text version of the message.
        /// </param>
        /// <param name="template"></param>
        /// <param name="headers">
        /// Custom headers to add to the email.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </param>
        /// <param name="attachments"></param>
        /// <param name="tags"></param>
        /// <param name="topicId">
        /// The topic ID to scope the email to. If the recipient is a contact and opted-in to the topic, the email is sent. If opted-out, the email is not sent. If the recipient is not a contact, the email is sent if the topic's default subscription is opt_in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.SendEmailResponse> CreateEmailsAsync(
            string from,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> to,
            string subject,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? replyTo = default,
            string? html = default,
            string? text = default,
            global::Resend.AllOf<global::Resend.EmailTemplateInput, object>? template = default,
            object? headers = default,
            string? scheduledAt = default,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments = default,
            global::System.Collections.Generic.IList<global::Resend.Tag>? tags = default,
            string? topicId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Resend.SendEmailRequest
            {
                From = from,
                To = to,
                Subject = subject,
                Bcc = bcc,
                Cc = cc,
                ReplyTo = replyTo,
                Html = html,
                Text = text,
                Template = template,
                Headers = headers,
                ScheduledAt = scheduledAt,
                Attachments = attachments,
                Tags = tags,
                TopicId = topicId,
            };

            return await CreateEmailsAsync(
                idempotencyKey: idempotencyKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}