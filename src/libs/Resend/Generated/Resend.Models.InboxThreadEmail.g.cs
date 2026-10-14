
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxThreadEmail
    {
        /// <summary>
        /// The ID of the message.<br/>
        /// Example: 5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60
        /// </summary>
        /// <example>5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether the inbox received the message (`inbound`) or sent it (`outbound`). A message the inbox sent to itself is `inbound`, so a reply to it goes to its sender.<br/>
        /// Example: inbound
        /// </summary>
        /// <example>inbound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxThreadEmailDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxThreadEmailDirection Direction { get; set; }

        /// <summary>
        /// Sender email address. Includes the display name when the sender has one, in the format "Name &lt;sender@domain.com&gt;".<br/>
        /// Example: Ada Lovelace &lt;ada@example.org&gt;
        /// </summary>
        /// <example>Ada Lovelace &lt;ada@example.org&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The recipients of the message. For a received message, these are the addresses it was delivered to, not the full `To` header.<br/>
        /// Example: [support@acme.com]
        /// </summary>
        /// <example>[support@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> To { get; set; }

        /// <summary>
        /// The CC recipients of the message.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// The BCC recipients of the message. Always empty for a received message.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// The Reply-To addresses of the message.<br/>
        /// Example: [replies@example.org]
        /// </summary>
        /// <example>[replies@example.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReplyTo { get; set; }

        /// <summary>
        /// The subject of the message.<br/>
        /// Example: Refund for order 1041
        /// </summary>
        /// <example>Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The Message-ID header of the message.<br/>
        /// Example: &lt;1041@example.org&gt;
        /// </summary>
        /// <example>&lt;1041@example.org&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Could I get a refund for order 1041?&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Could I get a refund for order 1041?&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain-text body.<br/>
        /// Example: Could I get a refund for order 1041?
        /// </summary>
        /// <example>Could I get a refund for order 1041?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The attachments of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxThreadEmailAttachment> Attachments { get; set; }

        /// <summary>
        /// Whether the message has been read.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Timestamp when the inbox received the message, or when the inbox sent it.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </summary>
        /// <example>2026-08-05T14:03:11.229Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReceivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmail" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the message.<br/>
        /// Example: 5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60
        /// </param>
        /// <param name="direction">
        /// Whether the inbox received the message (`inbound`) or sent it (`outbound`). A message the inbox sent to itself is `inbound`, so a reply to it goes to its sender.<br/>
        /// Example: inbound
        /// </param>
        /// <param name="from">
        /// Sender email address. Includes the display name when the sender has one, in the format "Name &lt;sender@domain.com&gt;".<br/>
        /// Example: Ada Lovelace &lt;ada@example.org&gt;
        /// </param>
        /// <param name="to">
        /// The recipients of the message. For a received message, these are the addresses it was delivered to, not the full `To` header.<br/>
        /// Example: [support@acme.com]
        /// </param>
        /// <param name="cc">
        /// The CC recipients of the message.<br/>
        /// Example: []
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients of the message. Always empty for a received message.<br/>
        /// Example: []
        /// </param>
        /// <param name="replyTo">
        /// The Reply-To addresses of the message.<br/>
        /// Example: [replies@example.org]
        /// </param>
        /// <param name="attachments">
        /// The attachments of the message.
        /// </param>
        /// <param name="read">
        /// Whether the message has been read.<br/>
        /// Example: false
        /// </param>
        /// <param name="receivedAt">
        /// Timestamp when the inbox received the message, or when the inbox sent it.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </param>
        /// <param name="subject">
        /// The subject of the message.<br/>
        /// Example: Refund for order 1041
        /// </param>
        /// <param name="messageId">
        /// The Message-ID header of the message.<br/>
        /// Example: &lt;1041@example.org&gt;
        /// </param>
        /// <param name="html">
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Could I get a refund for order 1041?&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain-text body.<br/>
        /// Example: Could I get a refund for order 1041?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadEmail(
            global::System.Guid id,
            global::Resend.InboxThreadEmailDirection direction,
            string from,
            global::System.Collections.Generic.IList<string> to,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.Collections.Generic.IList<string> replyTo,
            global::System.Collections.Generic.IList<global::Resend.InboxThreadEmailAttachment> attachments,
            bool read,
            global::System.DateTime receivedAt,
            string? subject,
            string? messageId,
            string? html,
            string? text)
        {
            this.Id = id;
            this.Direction = direction;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Cc = cc ?? throw new global::System.ArgumentNullException(nameof(cc));
            this.Bcc = bcc ?? throw new global::System.ArgumentNullException(nameof(bcc));
            this.ReplyTo = replyTo ?? throw new global::System.ArgumentNullException(nameof(replyTo));
            this.Subject = subject;
            this.MessageId = messageId;
            this.Html = html;
            this.Text = text;
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.Read = read;
            this.ReceivedAt = receivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmail" /> class.
        /// </summary>
        public InboxThreadEmail()
        {
        }

    }
}