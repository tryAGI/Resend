
#nullable enable

namespace Resend
{
    /// <summary>
    /// The email carried by an inbox webhook event. It has no `html` or `text`.
    /// </summary>
    public sealed partial class InboxEventEmail
    {
        /// <summary>
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </summary>
        /// <example>4ef9a417-02e9-4d39-ad75-9611e0fcc33c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether the email was received by the inbox or sent from it.<br/>
        /// Example: inbound
        /// </summary>
        /// <example>inbound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxEventEmailDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxEventEmailDirection Direction { get; set; }

        /// <summary>
        /// The sender, as an address or as `Name &lt;address&gt;`.<br/>
        /// Example: Steve Wozniak &lt;steve@acme.com&gt;
        /// </summary>
        /// <example>Steve Wozniak &lt;steve@acme.com&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The recipients of the email.<br/>
        /// Example: [support@acme.com]
        /// </summary>
        /// <example>[support@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> To { get; set; }

        /// <summary>
        /// The CC recipients of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// The BCC recipients of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// The Reply-To addresses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReplyTo { get; set; }

        /// <summary>
        /// The subject of the email.<br/>
        /// Example: Question about my invoice
        /// </summary>
        /// <example>Question about my invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The Message-ID header of the email.<br/>
        /// Example: &lt;CAF7c1f0a2e5d3b@mail.acme.com&gt;
        /// </summary>
        /// <example>&lt;CAF7c1f0a2e5d3b@mail.acme.com&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// The attachments on the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxEventEmailAttachment> Attachments { get; set; }

        /// <summary>
        /// Whether the email has been read.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Timestamp when the email arrived or was sent.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </summary>
        /// <example>2026-09-29T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReceivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventEmail" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </param>
        /// <param name="direction">
        /// Whether the email was received by the inbox or sent from it.<br/>
        /// Example: inbound
        /// </param>
        /// <param name="from">
        /// The sender, as an address or as `Name &lt;address&gt;`.<br/>
        /// Example: Steve Wozniak &lt;steve@acme.com&gt;
        /// </param>
        /// <param name="to">
        /// The recipients of the email.<br/>
        /// Example: [support@acme.com]
        /// </param>
        /// <param name="cc">
        /// The CC recipients of the email.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients of the email.
        /// </param>
        /// <param name="replyTo">
        /// The Reply-To addresses.
        /// </param>
        /// <param name="attachments">
        /// The attachments on the email.
        /// </param>
        /// <param name="read">
        /// Whether the email has been read.<br/>
        /// Example: false
        /// </param>
        /// <param name="receivedAt">
        /// Timestamp when the email arrived or was sent.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </param>
        /// <param name="subject">
        /// The subject of the email.<br/>
        /// Example: Question about my invoice
        /// </param>
        /// <param name="messageId">
        /// The Message-ID header of the email.<br/>
        /// Example: &lt;CAF7c1f0a2e5d3b@mail.acme.com&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxEventEmail(
            global::System.Guid id,
            global::Resend.InboxEventEmailDirection direction,
            string from,
            global::System.Collections.Generic.IList<string> to,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.Collections.Generic.IList<string> replyTo,
            global::System.Collections.Generic.IList<global::Resend.InboxEventEmailAttachment> attachments,
            bool read,
            global::System.DateTime receivedAt,
            string? subject,
            string? messageId)
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
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.Read = read;
            this.ReceivedAt = receivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventEmail" /> class.
        /// </summary>
        public InboxEventEmail()
        {
        }

    }
}