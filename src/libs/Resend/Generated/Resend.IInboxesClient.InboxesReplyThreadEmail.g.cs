#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
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
        global::System.Threading.Tasks.Task<global::Resend.ReplyInboxThreadEmailResponseSuccess> InboxesReplyThreadEmailAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ReplyInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
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
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ReplyInboxThreadEmailResponseSuccess>> InboxesReplyThreadEmailAsResponseAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,

            global::Resend.ReplyInboxThreadEmailOptions request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reply to a thread email<br/>
        /// Sends a reply from the inbox address right away, with no stored draft. The `to` recipients come from the message you reply to. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has no `Reply-To`. For a message the inbox sent, the reply goes to that message's `to` recipients. Set `reply_all` to also copy the other recipients of the message. The reply threads under the message through the `In-Reply-To` and `References` headers. When no recipient can be found for the reply, the request returns a 422. The whole email, encoded, can be at most 40 MB, or the request returns a 422.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="emailId"></param>
        /// <param name="cc">
        /// CC recipient email address. For multiple addresses, send as an array of strings. Without `reply_all`, the reply copies only these addresses. With `reply_all`, these addresses are merged with the copied recipients, without duplicates. `cc` and `bcc` combined must be fewer than 50 addresses. After the `to` recipients are added, the reply cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </param>
        /// <param name="bcc">
        /// BCC recipient email address. For multiple addresses, send as an array of strings. BCC recipients of the original message are never copied. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </param>
        /// <param name="html">
        /// The HTML body of the reply.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain-text body of the reply.<br/>
        /// Example: Refund issued for order 1041.
        /// </param>
        /// <param name="subject">
        /// The subject of the reply. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Re:` if it does not already start with it.<br/>
        /// Example: Re: Refund for order 1041
        /// </param>
        /// <param name="replyAll">
        /// Reply to everyone on the original message. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has none, and copies the other addresses of its `To` header and its `cc` recipients in `cc`. For a message the inbox sent, the reply goes to that message's `Reply-To` addresses when they are not the inbox address, otherwise to its `to` recipients, and copies its `cc` recipients. The inbox address is always excluded, and duplicates are removed.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="attachments">
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. The `content` of all files can total at most 25 MB. A `path` file does not count toward the 25 MB, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that does not start with `http` or that starts with `http://localhost:`, or a `content_type` that is not a valid MIME type returns a 422. Other `path` problems fail the email when it is sent, not the request.
        /// </param>
        /// <param name="headers">
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ReplyInboxThreadEmailResponseSuccess> InboxesReplyThreadEmailAsync(
            string inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            string? html = default,
            string? text = default,
            string? subject = default,
            bool? replyAll = default,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}