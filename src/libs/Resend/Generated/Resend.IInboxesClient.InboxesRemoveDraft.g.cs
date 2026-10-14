#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Remove an existing draft<br/>
        /// Discards an unsent draft. A draft that was already sent, or that changed during the request, returns a 409.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveInboxDraftResponseSuccess> InboxesRemoveDraftAsync(
            global::System.Guid inboxId,
            global::System.Guid draftId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an existing draft<br/>
        /// Discards an unsent draft. A draft that was already sent, or that changed during the request, returns a 409.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RemoveInboxDraftResponseSuccess>> InboxesRemoveDraftAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid draftId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}