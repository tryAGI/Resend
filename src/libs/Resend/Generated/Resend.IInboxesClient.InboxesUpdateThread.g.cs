#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, or moves it to a folder. At least one of `read` or `folder` is required. To change the labels of a thread, use the add, set, and remove thread labels endpoints. This endpoint ignores the removed `add_label_ids` and `remove_label_ids` fields, so a body with only those fields returns a 422 validation_error. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, then `folder`. They are not atomic.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadSummary> InboxesUpdateThreadAsync(
            string inboxId,
            global::System.Guid threadId,

            global::Resend.UpdateInboxThreadOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, or moves it to a folder. At least one of `read` or `folder` is required. To change the labels of a thread, use the add, set, and remove thread labels endpoints. This endpoint ignores the removed `add_label_ids` and `remove_label_ids` fields, so a body with only those fields returns a 422 validation_error. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, then `folder`. They are not atomic.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxThreadSummary>> InboxesUpdateThreadAsResponseAsync(
            string inboxId,
            global::System.Guid threadId,

            global::Resend.UpdateInboxThreadOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, or moves it to a folder. At least one of `read` or `folder` is required. To change the labels of a thread, use the add, set, and remove thread labels endpoints. This endpoint ignores the removed `add_label_ids` and `remove_label_ids` fields, so a body with only those fields returns a 422 validation_error. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, then `folder`. They are not atomic.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="read">
        /// Marks every email in the thread read or unread.<br/>
        /// Example: true
        /// </param>
        /// <param name="folder">
        /// Moves the thread to this folder. `sent` is assigned automatically and cannot be set.<br/>
        /// Example: archive
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadSummary> InboxesUpdateThreadAsync(
            string inboxId,
            global::System.Guid threadId,
            bool? read = default,
            global::Resend.UpdateInboxThreadOptionsFolder? folder = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}