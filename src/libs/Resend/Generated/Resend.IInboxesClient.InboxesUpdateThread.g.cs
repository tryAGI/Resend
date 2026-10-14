#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, moves it to a folder, or adds and removes labels. At least one of `read`, `folder`, `add_label_ids`, or `remove_label_ids` is required. A label ID cannot be both added and removed in the same request. Removing a label from a thread keeps the label itself. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, `folder`, added labels, removed labels. They are not atomic, so a 404 for a label leaves the earlier changes applied.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadSummary> InboxesUpdateThreadAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,

            global::Resend.UpdateInboxThreadOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, moves it to a folder, or adds and removes labels. At least one of `read`, `folder`, `add_label_ids`, or `remove_label_ids` is required. A label ID cannot be both added and removed in the same request. Removing a label from a thread keeps the label itself. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, `folder`, added labels, removed labels. They are not atomic, so a 404 for a label leaves the earlier changes applied.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxThreadSummary>> InboxesUpdateThreadAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,

            global::Resend.UpdateInboxThreadOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox thread<br/>
        /// Marks a thread read or unread, moves it to a folder, or adds and removes labels. At least one of `read`, `folder`, `add_label_ids`, or `remove_label_ids` is required. A label ID cannot be both added and removed in the same request. Removing a label from a thread keeps the label itself. Moving a thread out of `trash` restores it and clears its deletion deadline. The changes apply in this order: `read`, `folder`, added labels, removed labels. They are not atomic, so a 404 for a label leaves the earlier changes applied.
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
        /// <param name="addLabelIds">
        /// Label IDs to apply to the thread. Between 1 and 10 IDs. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </param>
        /// <param name="removeLabelIds">
        /// Label IDs to remove from the thread. Between 1 and 10 IDs. The labels themselves are kept. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [2b6d0f4e-8a1c-4e3b-9d57-1c0e8a6f4b21]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadSummary> InboxesUpdateThreadAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            bool? read = default,
            global::Resend.UpdateInboxThreadOptionsFolder? folder = default,
            global::System.Collections.Generic.IList<global::System.Guid>? addLabelIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? removeLabelIds = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}