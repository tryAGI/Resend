#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Retrieve broadcast recipients<br/>
        /// Retrieve the recipients of a broadcast for a given event type, such as who opened, clicked, or bounced.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="email"></param>
        /// <param name="bounceType"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListBroadcastRecipientsResponseSuccess> BroadcastsRecipientsAsync(
            global::System.Guid id,
            global::Resend.BroadcastsRecipientsType type,
            string? email = default,
            global::Resend.BroadcastsRecipientsBounceType? bounceType = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve broadcast recipients<br/>
        /// Retrieve the recipients of a broadcast for a given event type, such as who opened, clicked, or bounced.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="email"></param>
        /// <param name="bounceType"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListBroadcastRecipientsResponseSuccess>> BroadcastsRecipientsAsResponseAsync(
            global::System.Guid id,
            global::Resend.BroadcastsRecipientsType type,
            string? email = default,
            global::Resend.BroadcastsRecipientsBounceType? bounceType = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}