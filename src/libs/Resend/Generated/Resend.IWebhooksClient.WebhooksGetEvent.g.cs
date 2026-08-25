#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Retrieve a single webhook event
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetWebhookEventResponse> WebhooksGetEventAsync(
            global::System.Guid webhookId,
            string eventId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a single webhook event
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.GetWebhookEventResponse>> WebhooksGetEventAsResponseAsync(
            global::System.Guid webhookId,
            string eventId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}