#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Send a draft<br/>
        /// Sends the draft from the inbox address. A reply draft is sent in its thread. A draft without a thread starts a new thread. The draft must have at least one `to` recipient and `html` or `text`, or the request returns a 422. A standalone draft also needs a non-empty `subject`. A reply draft with an empty `subject` is sent with the thread subject, prefixed with `Re:` when it does not already start with it. A draft that was already sent returns a 409. The request body is optional and takes only `headers`. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendInboxDraftResponseSuccess> InboxesSendDraftAsync(
            string inboxId,
            global::System.Guid draftId,

            global::Resend.SendInboxDraftOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a draft<br/>
        /// Sends the draft from the inbox address. A reply draft is sent in its thread. A draft without a thread starts a new thread. The draft must have at least one `to` recipient and `html` or `text`, or the request returns a 422. A standalone draft also needs a non-empty `subject`. A reply draft with an empty `subject` is sent with the thread subject, prefixed with `Re:` when it does not already start with it. A draft that was already sent returns a 409. The request body is optional and takes only `headers`. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.SendInboxDraftResponseSuccess>> InboxesSendDraftAsResponseAsync(
            string inboxId,
            global::System.Guid draftId,

            global::Resend.SendInboxDraftOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a draft<br/>
        /// Sends the draft from the inbox address. A reply draft is sent in its thread. A draft without a thread starts a new thread. The draft must have at least one `to` recipient and `html` or `text`, or the request returns a 422. A standalone draft also needs a non-empty `subject`. A reply draft with an empty `subject` is sent with the thread subject, prefixed with `Re:` when it does not already start with it. A draft that was already sent returns a 409. The request body is optional and takes only `headers`. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="headers">
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendInboxDraftResponseSuccess> InboxesSendDraftAsync(
            string inboxId,
            global::System.Guid draftId,
            string? idempotencyKey = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}