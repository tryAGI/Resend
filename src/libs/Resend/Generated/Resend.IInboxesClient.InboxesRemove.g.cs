#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Remove an existing inbox<br/>
        /// Removes the inbox. An inbox that does not exist or was already removed returns a 404 not_found.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveInboxResponseSuccess> InboxesRemoveAsync(
            global::System.Guid inboxId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an existing inbox<br/>
        /// Removes the inbox. An inbox that does not exist or was already removed returns a 404 not_found.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RemoveInboxResponseSuccess>> InboxesRemoveAsResponseAsync(
            global::System.Guid inboxId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}