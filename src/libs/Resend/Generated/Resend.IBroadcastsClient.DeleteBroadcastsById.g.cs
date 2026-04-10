#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Remove an existing broadcast that is in the draft status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveBroadcastResponseSuccess> DeleteBroadcastsByIdAsync(
            string id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}