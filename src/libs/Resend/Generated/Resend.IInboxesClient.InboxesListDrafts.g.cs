#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve a list of drafts<br/>
        /// Returns the unsent drafts on the inbox, most recently updated first. The `after` and `before` cursors take a Draft ID from the current page, and only one of them can be passed. A cursor that is not a UUID, or both cursors together, return a 422. A cursor that is not an unsent draft on this inbox returns a 404.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListInboxDraftsResponseSuccess> InboxesListDraftsAsync(
            string inboxId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of drafts<br/>
        /// Returns the unsent drafts on the inbox, most recently updated first. The `after` and `before` cursors take a Draft ID from the current page, and only one of them can be passed. A cursor that is not a UUID, or both cursors together, return a 422. A cursor that is not an unsent draft on this inbox returns a 404.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxDraftsResponseSuccess>> InboxesListDraftsAsResponseAsync(
            string inboxId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}