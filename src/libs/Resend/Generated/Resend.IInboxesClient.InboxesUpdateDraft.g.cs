#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update an existing draft<br/>
        /// Updates the content of an unsent draft. Omitted fields are left unchanged. Send at least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments`. Sending `attachments` replaces every attachment on the draft. A request that sets `text` or `html` replaces the whole body. The body part you omit from that request becomes `null`. The merged draft must still contain at least one non-empty field, and its combined recipients cannot exceed 50. A draft that was already sent, or that changed during the request, returns a 409. The response holds only the Draft ID. Retrieve the draft to read its content.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxDraftResponseSuccess> InboxesUpdateDraftAsync(
            string inboxId,
            global::System.Guid draftId,

            global::Resend.UpdateInboxDraftOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing draft<br/>
        /// Updates the content of an unsent draft. Omitted fields are left unchanged. Send at least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments`. Sending `attachments` replaces every attachment on the draft. A request that sets `text` or `html` replaces the whole body. The body part you omit from that request becomes `null`. The merged draft must still contain at least one non-empty field, and its combined recipients cannot exceed 50. A draft that was already sent, or that changed during the request, returns a 409. The response holds only the Draft ID. Retrieve the draft to read its content.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateInboxDraftResponseSuccess>> InboxesUpdateDraftAsResponseAsync(
            string inboxId,
            global::System.Guid draftId,

            global::Resend.UpdateInboxDraftOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing draft<br/>
        /// Updates the content of an unsent draft. Omitted fields are left unchanged. Send at least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments`. Sending `attachments` replaces every attachment on the draft. A request that sets `text` or `html` replaces the whole body. The body part you omit from that request becomes `null`. The merged draft must still contain at least one non-empty field, and its combined recipients cannot exceed 50. A draft that was already sent, or that changed during the request, returns a 409. The response holds only the Draft ID. Retrieve the draft to read its content.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="draftId"></param>
        /// <param name="to">
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name. Pass `null` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </param>
        /// <param name="cc">
        /// The CC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="subject">
        /// The subject. Max 2000 characters. Cannot be only whitespace or contain a line break. Pass `null` to clear.<br/>
        /// Example: Refund issued for order 1041
        /// </param>
        /// <param name="html">
        /// The HTML body. Pass `null` to clear.
        /// </param>
        /// <param name="text">
        /// The plain text body. Pass `null` to clear.
        /// </param>
        /// <param name="attachments">
        /// Files to store on the draft. Each one needs `content`, `filename` and `content_type`. A `path` without `content` returns a 422, and when both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft can total at most 25 MB. An empty file or a blocked file type returns a 422. Sending the field replaces every attachment on the draft. Send `[]` to remove them all. `null` also removes them all.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxDraftResponseSuccess> InboxesUpdateDraftAsync(
            string inboxId,
            global::System.Guid draftId,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? to = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            string? subject = default,
            string? html = default,
            string? text = default,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? attachments = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}