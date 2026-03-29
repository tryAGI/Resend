
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReceivedEmailResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: email
        /// </summary>
        /// <example>email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

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
        /// The BCC recipients.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public global::System.Collections.Generic.IList<string>? Bcc { get; set; }

        /// <summary>
        /// The CC recipients.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public global::System.Collections.Generic.IList<string>? Cc { get; set; }

        /// <summary>
        /// The reply-to addresses.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// The HTML content of the email.<br/>
        /// Example: &lt;p&gt;Email content&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Email content&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text content of the email.<br/>
        /// Example: Email content
        /// </summary>
        /// <example>Email content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The email headers.<br/>
        /// Example: {"X-Custom-Header":"value"}
        /// </summary>
        /// <example>{"X-Custom-Header":"value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Timestamp when the email was received.<br/>
        /// Example: 2023-10-06:23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06:23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Array of attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReceivedEmailResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: email
        /// </param>
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
        /// The BCC recipients.<br/>
        /// Example: []
        /// </param>
        /// <param name="cc">
        /// The CC recipients.<br/>
        /// Example: []
        /// </param>
        /// <param name="replyTo">
        /// The reply-to addresses.<br/>
        /// Example: []
        /// </param>
        /// <param name="html">
        /// The HTML content of the email.<br/>
        /// Example: &lt;p&gt;Email content&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain text content of the email.<br/>
        /// Example: Email content
        /// </param>
        /// <param name="headers">
        /// The email headers.<br/>
        /// Example: {"X-Custom-Header":"value"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the email was received.<br/>
        /// Example: 2023-10-06:23:47:56.678Z
        /// </param>
        /// <param name="attachments">
        /// Array of attachments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReceivedEmailResponse(
            string? @object,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<string>? to,
            string? from,
            string? subject,
            string? messageId,
            global::System.Collections.Generic.IList<string>? bcc,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? html,
            string? text,
            object? headers,
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? attachments)
        {
            this.Object = @object;
            this.Id = id;
            this.To = to;
            this.From = from;
            this.Subject = subject;
            this.MessageId = messageId;
            this.Bcc = bcc;
            this.Cc = cc;
            this.ReplyTo = replyTo;
            this.Html = html;
            this.Text = text;
            this.Headers = headers;
            this.CreatedAt = createdAt;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReceivedEmailResponse" /> class.
        /// </summary>
        public GetReceivedEmailResponse()
        {
        }
    }
}