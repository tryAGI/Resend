#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Forward a thread email<br/>
        /// Forwards a message from the inbox address right away, with no stored draft. The original message is quoted under a forwarded-message banner, below the optional `html` or `text` note. The attachments of the original message are sent with the forward, together with any `attachments` you add. The request fails when they exceed 10 files or 25 MB of `content` in total. An original attachment that was sent from a URL (`path`) cannot be forwarded, and the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ForwardInboxThreadEmailResponseSuccess> InboxesForwardThreadEmailAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ForwardInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward a thread email<br/>
        /// Forwards a message from the inbox address right away, with no stored draft. The original message is quoted under a forwarded-message banner, below the optional `html` or `text` note. The attachments of the original message are sent with the forward, together with any `attachments` you add. The request fails when they exceed 10 files or 25 MB of `content` in total. An original attachment that was sent from a URL (`path`) cannot be forwarded, and the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ForwardInboxThreadEmailResponseSuccess>> InboxesForwardThreadEmailAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ForwardInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forward a thread email<br/>
        /// Forwards a message from the inbox address right away, with no stored draft. The original message is quoted under a forwarded-message banner, below the optional `html` or `text` note. The attachments of the original message are sent with the forward, together with any `attachments` you add. The request fails when they exceed 10 files or 25 MB of `content` in total. An original attachment that was sent from a URL (`path`) cannot be forwarded, and the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="to">
        /// Recipient email address. For multiple addresses, send as an array of strings. Must name at least one address. `to`, `cc` and `bcc` combined cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [colleague@example.org]
        /// </param>
        /// <param name="cc">
        /// CC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </param>
        /// <param name="bcc">
        /// BCC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </param>
        /// <param name="html">
        /// An HTML note sent above the quoted original.<br/>
        /// Example: &lt;p&gt;Flagging this refund request for you.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// A plain-text note sent above the quoted original.<br/>
        /// Example: Flagging this refund request for you.
        /// </param>
        /// <param name="subject">
        /// The subject of the forward. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Fwd:` if it does not already start with it.<br/>
        /// Example: Fwd: Refund for order 1041
        /// </param>
        /// <param name="attachments">
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. They share one limit with the attachments of the original message, which the forward also sends. Together they can have up to 10 files and at most 25 MB of `content`. A `path` file counts toward the 10 files only, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that is not an `http` or `https` URL or that points to `localhost`, `127.0.0.1` or `0.0.0.0`, or a `content_type` that is not a valid MIME type returns a 422.
        /// </param>
        /// <param name="headers">
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ForwardInboxThreadEmailResponseSuccess> InboxesForwardThreadEmailAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> to,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            string? html = default,
            string? text = default,
            string? subject = default,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}