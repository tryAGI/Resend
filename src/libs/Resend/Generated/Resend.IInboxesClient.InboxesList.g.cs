#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve a list of inboxes<br/>
        /// Returns the inboxes of the team, newest first. The list items carry fewer fields than a single inbox. Retrieve an inbox to get all its fields. The `after` and `before` cursors take an inbox ID, and only one of them can be passed, or the request returns a 422. A value that is not a UUID returns a 422, and an unknown ID returns a 404.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListInboxesResponseSuccess> InboxesListAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of inboxes<br/>
        /// Returns the inboxes of the team, newest first. The list items carry fewer fields than a single inbox. Retrieve an inbox to get all its fields. The `after` and `before` cursors take an inbox ID, and only one of them can be passed, or the request returns a 422. A value that is not a UUID returns a 422, and an unknown ID returns a 404.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxesResponseSuccess>> InboxesListAsResponseAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}