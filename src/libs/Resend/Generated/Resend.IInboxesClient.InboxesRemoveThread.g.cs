#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Remove an existing inbox thread<br/>
        /// Moves the thread to `trash` and schedules it for deletion in 30 days. This is reversible. To restore the thread, update its `folder` to `inbox`, `archive`, or `spam`, which also clears the deletion deadline.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveInboxThreadResponseSuccess> InboxesRemoveThreadAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an existing inbox thread<br/>
        /// Moves the thread to `trash` and schedules it for deletion in 30 days. This is reversible. To restore the thread, update its `folder` to `inbox`, `archive`, or `spam`, which also clears the deletion deadline.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RemoveInboxThreadResponseSuccess>> InboxesRemoveThreadAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}