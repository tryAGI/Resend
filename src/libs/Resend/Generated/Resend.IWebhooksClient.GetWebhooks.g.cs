#nullable enable

namespace Resend
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Retrieve a list of webhooks
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListWebhooksResponse> GetWebhooksAsync(
            int? limit = default,
            global::System.Guid? after = default,
            global::System.Guid? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}