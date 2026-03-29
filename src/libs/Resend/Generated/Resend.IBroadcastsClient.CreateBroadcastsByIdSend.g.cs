#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Send or schedule a broadcast
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendBroadcastResponseSuccess> CreateBroadcastsByIdSendAsync(
            string id,

            global::Resend.SendBroadcastOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send or schedule a broadcast
        /// </summary>
        /// <param name="id"></param>
        /// <param name="scheduledAt">
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendBroadcastResponseSuccess> CreateBroadcastsByIdSendAsync(
            string id,
            string? scheduledAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}