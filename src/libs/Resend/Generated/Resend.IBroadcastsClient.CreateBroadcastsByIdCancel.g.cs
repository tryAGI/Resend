#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Cancel a broadcast<br/>
        /// Cancels a broadcast that is queued or scheduled. Canceling a queued broadcast stops it mid-send; emails already sent are not affected, but no further emails will go out.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CancelBroadcastResponseSuccess> CreateBroadcastsByIdCancelAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a broadcast<br/>
        /// Cancels a broadcast that is queued or scheduled. Canceling a queued broadcast stops it mid-send; emails already sent are not affected, but no further emails will go out.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CancelBroadcastResponseSuccess>> CreateBroadcastsByIdCancelAsResponseAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}