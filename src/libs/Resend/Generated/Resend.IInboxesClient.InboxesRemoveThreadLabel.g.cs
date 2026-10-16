#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Remove a label from an inbox thread<br/>
        /// Takes one label off the thread. The label itself is kept, and stays on every other thread that carries it. To delete the label, use the remove inbox label endpoint. The response lists every label on the thread after the change. A label that is not on the thread returns a 200 with the current labels. A label ID that is not a label of the inbox returns a 404 `Label not found.`. A thread that does not exist in the inbox returns a 404 `Thread not found.`.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="labelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadLabelList> InboxesRemoveThreadLabelAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Guid labelId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a label from an inbox thread<br/>
        /// Takes one label off the thread. The label itself is kept, and stays on every other thread that carries it. To delete the label, use the remove inbox label endpoint. The response lists every label on the thread after the change. A label that is not on the thread returns a 200 with the current labels. A label ID that is not a label of the inbox returns a 404 `Label not found.`. A thread that does not exist in the inbox returns a 404 `Thread not found.`.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="labelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxThreadLabelList>> InboxesRemoveThreadLabelAsResponseAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Guid labelId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}