#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Create a draft<br/>
        /// Creates an unsent draft on the inbox. Omit `thread_id` and `reply_to_email_id` for a draft that starts a new thread. Pass both together for a reply draft in an existing thread. A reply draft without `to` is addressed to the sender of the email it replies to, or to its Reply-To when set. For an email the inbox sent, it defaults to that email's `to` recipients. Send `to: []` to leave it empty. At least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments` must be non-empty. The combined recipients of `to`, `cc` and `bcc` cannot exceed 50. Attachments are stored on the draft, so a `path` file is downloaded when the request is made. Returns 201 for a new draft. Only one unsent reply draft can target an email, so a reply draft request for an email that already has one returns 200 with the ID of the existing draft. An unknown `thread_id`, or a `reply_to_email_id` that is not in that thread, returns a 404. That request ignores every other field, except `attachments`, which replaces the attachments of the existing draft when sent. A reply draft created without `subject` stores an empty subject. When it is sent, it takes the thread subject, prefixed with `Re:` when it does not already start with it.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxDraftResponseSuccess> InboxesCreateDraftAsync(
            string inboxId,

            global::Resend.CreateInboxDraftOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a draft<br/>
        /// Creates an unsent draft on the inbox. Omit `thread_id` and `reply_to_email_id` for a draft that starts a new thread. Pass both together for a reply draft in an existing thread. A reply draft without `to` is addressed to the sender of the email it replies to, or to its Reply-To when set. For an email the inbox sent, it defaults to that email's `to` recipients. Send `to: []` to leave it empty. At least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments` must be non-empty. The combined recipients of `to`, `cc` and `bcc` cannot exceed 50. Attachments are stored on the draft, so a `path` file is downloaded when the request is made. Returns 201 for a new draft. Only one unsent reply draft can target an email, so a reply draft request for an email that already has one returns 200 with the ID of the existing draft. An unknown `thread_id`, or a `reply_to_email_id` that is not in that thread, returns a 404. That request ignores every other field, except `attachments`, which replaces the attachments of the existing draft when sent. A reply draft created without `subject` stores an empty subject. When it is sent, it takes the thread subject, prefixed with `Re:` when it does not already start with it.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CreateInboxDraftResponseSuccess>> InboxesCreateDraftAsResponseAsync(
            string inboxId,

            global::Resend.CreateInboxDraftOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a draft<br/>
        /// Creates an unsent draft on the inbox. Omit `thread_id` and `reply_to_email_id` for a draft that starts a new thread. Pass both together for a reply draft in an existing thread. A reply draft without `to` is addressed to the sender of the email it replies to, or to its Reply-To when set. For an email the inbox sent, it defaults to that email's `to` recipients. Send `to: []` to leave it empty. At least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments` must be non-empty. The combined recipients of `to`, `cc` and `bcc` cannot exceed 50. Attachments are stored on the draft, so a `path` file is downloaded when the request is made. Returns 201 for a new draft. Only one unsent reply draft can target an email, so a reply draft request for an email that already has one returns 200 with the ID of the existing draft. An unknown `thread_id`, or a `reply_to_email_id` that is not in that thread, returns a 404. That request ignores every other field, except `attachments`, which replaces the attachments of the existing draft when sent. A reply draft created without `subject` stores an empty subject. When it is sent, it takes the thread subject, prefixed with `Re:` when it does not already start with it.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="to">
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name, for example `Ada Lovelace &lt;ada@example.org&gt;`. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </param>
        /// <param name="cc">
        /// The CC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="subject">
        /// The subject. Max 2000 characters. A string that is only whitespace, or that contains a line break, is rejected.<br/>
        /// Example: Refund for order 1041
        /// </param>
        /// <param name="html">
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain text body.<br/>
        /// Example: Refund issued for order 1041.
        /// </param>
        /// <param name="attachments">
        /// Files to store on the draft. Each one needs a `filename` and either `content` or a `path` URL. A `path` file is downloaded when the request is made and stored on the draft. When both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft, downloaded ones included, can total at most 25 MB. A `path` that does not start with `http` or `https`, or that cannot be downloaded, returns a 422, and so does a request whose downloads take more than 20 seconds together. An empty file or a blocked file type returns a 422.
        /// </param>
        /// <param name="threadId">
        /// The Thread ID to reply in. Must be sent with `reply_to_email_id`.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </param>
        /// <param name="replyToEmailId">
        /// The Email ID to reply to, as returned in `data[].id` by the list thread emails endpoint. Must be sent with `thread_id`.<br/>
        /// Example: 5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxDraftResponseSuccess> InboxesCreateDraftAsync(
            string inboxId,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? to = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            string? subject = default,
            string? html = default,
            string? text = default,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? attachments = default,
            global::System.Guid? threadId = default,
            global::System.Guid? replyToEmailId = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}