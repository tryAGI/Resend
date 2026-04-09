
#nullable enable

namespace Resend
{
    public partial class ReceivingEmailsClient
    {


        private static readonly global::Resend.EndPointSecurityRequirement s_GetEmailsReceivingByEmailIdAttachmentsSecurityRequirement0 =
            new global::Resend.EndPointSecurityRequirement
            {
                Authorizations = new global::Resend.EndPointAuthorizationRequirement[]
                {                    new global::Resend.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Resend.EndPointSecurityRequirement[] s_GetEmailsReceivingByEmailIdAttachmentsSecurityRequirements =
            new global::Resend.EndPointSecurityRequirement[]
            {                s_GetEmailsReceivingByEmailIdAttachmentsSecurityRequirement0,
            };
        partial void PrepareGetEmailsReceivingByEmailIdAttachmentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid emailId,
            ref int? limit,
            ref global::System.Guid? after,
            ref global::System.Guid? before);
        partial void PrepareGetEmailsReceivingByEmailIdAttachmentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid emailId,
            int? limit,
            global::System.Guid? after,
            global::System.Guid? before);
        partial void ProcessGetEmailsReceivingByEmailIdAttachmentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetEmailsReceivingByEmailIdAttachmentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve a list of attachments for a received email
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Resend.ListAttachmentsResponse> GetEmailsReceivingByEmailIdAttachmentsAsync(
            global::System.Guid emailId,
            int? limit = default,
            global::System.Guid? after = default,
            global::System.Guid? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetEmailsReceivingByEmailIdAttachmentsArguments(
                httpClient: HttpClient,
                emailId: ref emailId,
                limit: ref limit,
                after: ref after,
                before: ref before);


            var __authorizations = global::Resend.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetEmailsReceivingByEmailIdAttachmentsSecurityRequirements,
                operationName: "GetEmailsReceivingByEmailIdAttachmentsAsync");

            var __pathBuilder = new global::Resend.PathBuilder(
                path: $"/emails/receiving/{emailId}/attachments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("after", after?.ToString())
                .AddOptionalParameter("before", before?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetEmailsReceivingByEmailIdAttachmentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                emailId: emailId,
                limit: limit,
                after: after,
                before: before);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetEmailsReceivingByEmailIdAttachmentsResponse(
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
                ProcessGetEmailsReceivingByEmailIdAttachmentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Resend.ListAttachmentsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Resend.ListAttachmentsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}