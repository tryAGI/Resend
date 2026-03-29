#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateWebhookResponse> EditWebhooksByWebhookIdAsync(
            global::System.Guid webhookId,

            global::Resend.UpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="endpoint">
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/new-handler
        /// </param>
        /// <param name="events">
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered]
        /// </param>
        /// <param name="status">
        /// The status of the webhook.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateWebhookResponse> EditWebhooksByWebhookIdAsync(
            global::System.Guid webhookId,
            string? endpoint = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::Resend.UpdateWebhookRequestStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}