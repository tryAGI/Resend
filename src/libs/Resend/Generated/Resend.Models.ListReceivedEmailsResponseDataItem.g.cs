
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListReceivedEmailsResponseDataItem
    {
        /// <summary>
        /// The ID of the received email.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The recipient email addresses.<br/>
        /// Example: [delivered@resend.dev]
        /// </summary>
        /// <example>[delivered@resend.dev]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.Collections.Generic.IList<string>? To { get; set; }

        /// <summary>
        /// The sender email address.<br/>
        /// Example: sender@example.com
        /// </summary>
        /// <example>sender@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The email subject.<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The unique message ID from the email headers.<br/>
        /// Example: &lt;message-id@example.com&gt;
        /// </summary>
        /// <example>&lt;message-id@example.com&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// The BCC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public global::System.Collections.Generic.IList<string>? Bcc { get; set; }

        /// <summary>
        /// The CC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public global::System.Collections.Generic.IList<string>? Cc { get; set; }

        /// <summary>
        /// The reply-to addresses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// Timestamp when the email was received.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Array of attachments for this email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReceivedEmailsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the received email.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="to">
        /// The recipient email addresses.<br/>
        /// Example: [delivered@resend.dev]
        /// </param>
        /// <param name="from">
        /// The sender email address.<br/>
        /// Example: sender@example.com
        /// </param>
        /// <param name="subject">
        /// The email subject.<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="messageId">
        /// The unique message ID from the email headers.<br/>
        /// Example: &lt;message-id@example.com&gt;
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients.
        /// </param>
        /// <param name="cc">
        /// The CC recipients.
        /// </param>
        /// <param name="replyTo">
        /// The reply-to addresses.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the email was received.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="attachments">
        /// Array of attachments for this email.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListReceivedEmailsResponseDataItem(
            global::System.Guid? id,
            global::System.Collections.Generic.IList<string>? to,
            string? from,
            string? subject,
            string? messageId,
            global::System.Collections.Generic.IList<string>? bcc,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? replyTo,
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? attachments)
        {
            this.Id = id;
            this.To = to;
            this.From = from;
            this.Subject = subject;
            this.MessageId = messageId;
            this.Bcc = bcc;
            this.Cc = cc;
            this.ReplyTo = replyTo;
            this.CreatedAt = createdAt;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReceivedEmailsResponseDataItem" /> class.
        /// </summary>
        public ListReceivedEmailsResponseDataItem()
        {
        }
    }
}