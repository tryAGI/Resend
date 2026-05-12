
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailReceivedEventData
    {
        /// <summary>
        /// Unique identifier for the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailId { get; set; }

        /// <summary>
        /// Timestamp when the email was received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Sender email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Array of recipient email addresses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> To { get; set; }

        /// <summary>
        /// Email subject line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// The unique message ID from the email headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// BCC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// CC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// Array of attachment metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment> Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailReceivedEventData" /> class.
        /// </summary>
        /// <param name="emailId">
        /// Unique identifier for the email.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the email was received.
        /// </param>
        /// <param name="from">
        /// Sender email address.
        /// </param>
        /// <param name="to">
        /// Array of recipient email addresses.
        /// </param>
        /// <param name="subject">
        /// Email subject line.
        /// </param>
        /// <param name="messageId">
        /// The unique message ID from the email headers.
        /// </param>
        /// <param name="bcc">
        /// BCC recipients.
        /// </param>
        /// <param name="cc">
        /// CC recipients.
        /// </param>
        /// <param name="attachments">
        /// Array of attachment metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailReceivedEventData(
            string emailId,
            global::System.DateTime createdAt,
            string from,
            global::System.Collections.Generic.IList<string> to,
            string subject,
            string messageId,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment> attachments)
        {
            this.EmailId = emailId ?? throw new global::System.ArgumentNullException(nameof(emailId));
            this.CreatedAt = createdAt;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Bcc = bcc ?? throw new global::System.ArgumentNullException(nameof(bcc));
            this.Cc = cc ?? throw new global::System.ArgumentNullException(nameof(cc));
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailReceivedEventData" /> class.
        /// </summary>
        public EmailReceivedEventData()
        {
        }

    }
}