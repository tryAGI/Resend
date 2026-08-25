#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Retrieve a list of webhook event attempts
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListWebhookEventAttemptsResponse> WebhooksListEventAttemptsAsync(
            global::System.Guid webhookId,
            string eventId,
            int? limit = default,
            string? after = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of webhook event attempts
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListWebhookEventAttemptsResponse>> WebhooksListEventAttemptsAsResponseAsync(
            global::System.Guid webhookId,
            string eventId,
            int? limit = default,
            string? after = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}