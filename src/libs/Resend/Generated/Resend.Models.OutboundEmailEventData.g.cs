
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutboundEmailEventData
    {
        /// <summary>
        /// Unique identifier for the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailId { get; set; }

        /// <summary>
        /// Timestamp when the email was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Sender email address and name in the format `Name &lt;email@domain.com&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Array of impacted recipient email addresses.
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
        /// Unique identifier for the broadcast campaign, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_id")]
        public string? BroadcastId { get; set; }

        /// <summary>
        /// Unique identifier for the template used, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Tag key-value pairs associated with the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Custom headers included with the email (omitted when no custom headers are set).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundEmailEventData" /> class.
        /// </summary>
        /// <param name="emailId">
        /// Unique identifier for the email.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the email was created.
        /// </param>
        /// <param name="from">
        /// Sender email address and name in the format `Name &lt;email@domain.com&gt;`.
        /// </param>
        /// <param name="to">
        /// Array of impacted recipient email addresses.
        /// </param>
        /// <param name="subject">
        /// Email subject line.
        /// </param>
        /// <param name="broadcastId">
        /// Unique identifier for the broadcast campaign, if applicable.
        /// </param>
        /// <param name="templateId">
        /// Unique identifier for the template used, if applicable.
        /// </param>
        /// <param name="tags">
        /// Tag key-value pairs associated with the email.
        /// </param>
        /// <param name="headers">
        /// Custom headers included with the email (omitted when no custom headers are set).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutboundEmailEventData(
            string emailId,
            global::System.DateTime createdAt,
            string from,
            global::System.Collections.Generic.IList<string> to,
            string subject,
            string? broadcastId,
            string? templateId,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? headers)
        {
            this.EmailId = emailId ?? throw new global::System.ArgumentNullException(nameof(emailId));
            this.CreatedAt = createdAt;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.BroadcastId = broadcastId;
            this.TemplateId = templateId;
            this.Tags = tags;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundEmailEventData" /> class.
        /// </summary>
        public OutboundEmailEventData()
        {
        }

    }
}