#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Add labels to an inbox thread<br/>
        /// Applies one or more labels to the thread. Labels already on the thread stay on it. The response lists every label on the thread after the change. A label ID that is not a label of the inbox returns a 404 `Label not found.`, and nothing changes. A thread that does not exist in the inbox returns a 404 `Thread not found.`. To replace the labels of the thread, use the set thread labels endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadLabelList> InboxesAddThreadLabelsAsync(
            string inboxId,
            global::System.Guid threadId,

            global::Resend.AddInboxThreadLabelsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add labels to an inbox thread<br/>
        /// Applies one or more labels to the thread. Labels already on the thread stay on it. The response lists every label on the thread after the change. A label ID that is not a label of the inbox returns a 404 `Label not found.`, and nothing changes. A thread that does not exist in the inbox returns a 404 `Thread not found.`. To replace the labels of the thread, use the set thread labels endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxThreadLabelList>> InboxesAddThreadLabelsAsResponseAsync(
            string inboxId,
            global::System.Guid threadId,

            global::Resend.AddInboxThreadLabelsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add labels to an inbox thread<br/>
        /// Applies one or more labels to the thread. Labels already on the thread stay on it. The response lists every label on the thread after the change. A label ID that is not a label of the inbox returns a 404 `Label not found.`, and nothing changes. A thread that does not exist in the inbox returns a 404 `Thread not found.`. To replace the labels of the thread, use the set thread labels endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="labels">
        /// The IDs of the labels to apply to the thread. Between 1 and 10 IDs, each a label of the inbox.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadLabelList> InboxesAddThreadLabelsAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Collections.Generic.IList<global::System.Guid> labels,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}