#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Replay a webhook event<br/>
        /// Queues one more delivery of the event to the webhook. The event must be retrievable through the get event endpoint and the webhook must be enabled; a disabled webhook returns a 422 validation_error. A manual replay does not schedule automatic retries.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ReplayWebhookEventResponse> WebhooksReplayEventAsync(
            global::System.Guid webhookId,
            string eventId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replay a webhook event<br/>
        /// Queues one more delivery of the event to the webhook. The event must be retrievable through the get event endpoint and the webhook must be enabled; a disabled webhook returns a 422 validation_error. A manual replay does not schedule automatic retries.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="eventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ReplayWebhookEventResponse>> WebhooksReplayEventAsResponseAsync(
            global::System.Guid webhookId,
            string eventId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}