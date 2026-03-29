#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a new webhook
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateWebhookResponse> CreateWebhooksAsync(

            global::Resend.CreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new webhook
        /// </summary>
        /// <param name="endpoint">
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/handler
        /// </param>
        /// <param name="events">
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered, email.bounced]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateWebhookResponse> CreateWebhooksAsync(
            string endpoint,
            global::System.Collections.Generic.IList<string> events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}