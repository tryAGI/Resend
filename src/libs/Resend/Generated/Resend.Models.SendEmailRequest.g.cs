
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendEmailRequest
    {
        /// <summary>
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Recipient email address. For multiple addresses, send as an array of strings. Max 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> To { get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// Bcc recipient email address. For multiple addresses, send as an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Bcc { get; set; }

        /// <summary>
        /// Cc recipient email address. For multiple addresses, send as an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Cc { get; set; }

        /// <summary>
        /// Reply-to email address. For multiple addresses, send as an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? ReplyTo { get; set; }

        /// <summary>
        /// The HTML version of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text version of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AllOfJsonConverter<global::Resend.EmailTemplateInput, object>))]
        public global::Resend.AllOf<global::Resend.EmailTemplateInput, object>? Template { get; set; }

        /// <summary>
        /// Custom headers to add to the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public string? ScheduledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.Attachment>? Attachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Resend.Tag>? Tags { get; set; }

        /// <summary>
        /// The topic ID to scope the email to. If the recipient is a contact and opted-in to the topic, the email is sent. If opted-out, the email is not sent. If the recipient is not a contact, the email is sent if the topic's default subscription is opt_in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailRequest" /> class.
        /// </summary>
        /// <param name="from">
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </param>
        /// <param name="to">
        /// Recipient email address. For multiple addresses, send as an array of strings. Max 50.
        /// </param>
        /// <param name="subject">
        /// Email subject.
        /// </param>
        /// <param name="bcc">
        /// Bcc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="cc">
        /// Cc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="replyTo">
        /// Reply-to email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="html">
        /// The HTML version of the message.
        /// </param>
        /// <param name="text">
        /// The plain text version of the message.
        /// </param>
        /// <param name="template"></param>
        /// <param name="headers">
        /// Custom headers to add to the email.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </param>
        /// <param name="attachments"></param>
        /// <param name="tags"></param>
        /// <param name="topicId">
        /// The topic ID to scope the email to. If the recipient is a contact and opted-in to the topic, the email is sent. If opted-out, the email is not sent. If the recipient is not a contact, the email is sent if the topic's default subscription is opt_in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendEmailRequest(
            string from,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> to,
            string subject,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? replyTo,
            string? html,
            string? text,
            global::Resend.AllOf<global::Resend.EmailTemplateInput, object>? template,
            object? headers,
            string? scheduledAt,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments,
            global::System.Collections.Generic.IList<global::Resend.Tag>? tags,
            string? topicId)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to;
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Bcc = bcc;
            this.Cc = cc;
            this.ReplyTo = replyTo;
            this.Html = html;
            this.Text = text;
            this.Template = template;
            this.Headers = headers;
            this.ScheduledAt = scheduledAt;
            this.Attachments = attachments;
            this.Tags = tags;
            this.TopicId = topicId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailRequest" /> class.
        /// </summary>
        public SendEmailRequest()
        {
        }
    }
}