#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Retrieve a single webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetWebhookResponse> GetWebhooksByWebhookIdAsync(
            global::System.Guid webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}