
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `html` or `text` must contain more than whitespace.
    /// </summary>
    public sealed partial class ReplyInboxThreadEmailOptions
    {
        /// <summary>
        /// CC recipient email address. For multiple addresses, send as an array of strings. Without `reply_all`, the reply copies only these addresses. With `reply_all`, these addresses are merged with the copied recipients, without duplicates. `cc` and `bcc` combined must be fewer than 50 addresses. After the `to` recipients are added, the reply cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </summary>
        /// <example>[billing@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Cc { get; set; }

        /// <summary>
        /// BCC recipient email address. For multiple addresses, send as an array of strings. BCC recipients of the original message are never copied. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </summary>
        /// <example>[records@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Bcc { get; set; }

        /// <summary>
        /// The HTML body of the reply.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Refund issued for order 1041.&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain-text body of the reply.<br/>
        /// Example: Refund issued for order 1041.
        /// </summary>
        /// <example>Refund issued for order 1041.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The subject of the reply. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Re:` if it does not already start with it.<br/>
        /// Example: Re: Refund for order 1041
        /// </summary>
        /// <example>Re: Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Reply to everyone on the original message. For a message the inbox received, the reply goes to its `Reply-To` addresses, or to its sender when it has none, and copies the other addresses of its `To` header and its `cc` recipients in `cc`. For a message the inbox sent, the reply goes to that message's `Reply-To` addresses when they are not the inbox address, otherwise to its `to` recipients, and copies its `cc` recipients. The inbox address is always excluded, and duplicates are removed.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_all")]
        public bool? ReplyAll { get; set; }

        /// <summary>
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. The `content` of all files can total at most 25 MB. A `path` file does not count toward the 25 MB, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that does not start with `http` or that starts with `http://localhost:`, or a `content_type` that is not a valid MIME type returns a 422. Other `path` problems fail the email when it is sent, not the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.Attachment>? Attachments { get; set; }

        /// <summary>
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </summary>
        /// <example>{"X-Ticket-Id":"4821"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyInboxThreadEmailOptions" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyInboxThreadEmailOptions(
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc,
            string? html,
            string? text,
            string? subject,
            bool? replyAll,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Cc = cc;
            this.Bcc = bcc;
            this.Html = html;
            this.Text = text;
            this.Subject = subject;
            this.ReplyAll = replyAll;
            this.Attachments = attachments;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyInboxThreadEmailOptions" /> class.
        /// </summary>
        public ReplyInboxThreadEmailOptions()
        {
        }

    }
}