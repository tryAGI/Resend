#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Rotate a webhook signing secret<br/>
        /// Generates a new signing secret for the webhook and returns it. Payloads delivered after the rotation are signed with the new secret. The previous secret keeps verifying payloads for 24 hours, so both secrets are accepted during that window. A webhook that does not exist or was removed returns a 404 not_found.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RotateWebhookSigningSecretResponse> WebhooksRotateSigningSecretAsync(
            global::System.Guid webhookId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a webhook signing secret<br/>
        /// Generates a new signing secret for the webhook and returns it. Payloads delivered after the rotation are signed with the new secret. The previous secret keeps verifying payloads for 24 hours, so both secrets are accepted during that window. A webhook that does not exist or was removed returns a 404 not_found.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RotateWebhookSigningSecretResponse>> WebhooksRotateSigningSecretAsResponseAsync(
            global::System.Guid webhookId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}