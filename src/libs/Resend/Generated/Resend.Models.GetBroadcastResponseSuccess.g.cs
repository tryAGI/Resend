
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBroadcastResponseSuccess
    {
        /// <summary>
        /// Unique identifier for the broadcast.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the broadcast.<br/>
        /// Example: November announcements
        /// </summary>
        /// <example>November announcements</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated: use `segment_id` instead. Unique identifier of the segment this broadcast will be sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_id")]
        public string? SegmentId { get; set; }

        /// <summary>
        /// The email address of the sender.<br/>
        /// Example: Acme &lt;onboarding@resend.dev&gt;
        /// </summary>
        /// <example>Acme &lt;onboarding@resend.dev&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The subject line of the email.<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The email addresses to which replies should be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// The preview text of the email.<br/>
        /// Example: Here are our announcements
        /// </summary>
        /// <example>Here are our announcements</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_text")]
        public string? PreviewText { get; set; }

        /// <summary>
        /// The status of the broadcast.<br/>
        /// Example: draft
        /// </summary>
        /// <example>draft</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Timestamp indicating when the broadcast was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </summary>
        /// <example>2023-10-06T22:59:55.977Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the broadcast is scheduled to be sent.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </summary>
        /// <example>2023-10-06T22:59:55.977Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the broadcast was sent.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </summary>
        /// <example>2023-10-06T22:59:55.977Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_at")]
        public global::System.DateTime? SentAt { get; set; }

        /// <summary>
        /// The plain text version of the broadcast content.<br/>
        /// Example: Hello {{{FIRST_NAME|there}}}!
        /// </summary>
        /// <example>Hello {{{FIRST_NAME|there}}}!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The HTML version of the broadcast content.<br/>
        /// Example: &lt;p&gt;Hello {{{FIRST_NAME|there}}}!&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Hello {{{FIRST_NAME|there}}}!&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The topic ID that the broadcast is scoped to.<br/>
        /// Example: b6d24b8e-af0b-4c3c-be0c-359bbd97381e
        /// </summary>
        /// <example>b6d24b8e-af0b-4c3c-be0c-359bbd97381e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBroadcastResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the broadcast.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
        /// <param name="name">
        /// Name of the broadcast.<br/>
        /// Example: November announcements
        /// </param>
        /// <param name="segmentId">
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </param>
        /// <param name="from">
        /// The email address of the sender.<br/>
        /// Example: Acme &lt;onboarding@resend.dev&gt;
        /// </param>
        /// <param name="subject">
        /// The subject line of the email.<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="replyTo">
        /// The email addresses to which replies should be sent.
        /// </param>
        /// <param name="previewText">
        /// The preview text of the email.<br/>
        /// Example: Here are our announcements
        /// </param>
        /// <param name="status">
        /// The status of the broadcast.<br/>
        /// Example: draft
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the broadcast was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </param>
        /// <param name="scheduledAt">
        /// Timestamp indicating when the broadcast is scheduled to be sent.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </param>
        /// <param name="sentAt">
        /// Timestamp indicating when the broadcast was sent.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </param>
        /// <param name="text">
        /// The plain text version of the broadcast content.<br/>
        /// Example: Hello {{{FIRST_NAME|there}}}!
        /// </param>
        /// <param name="html">
        /// The HTML version of the broadcast content.<br/>
        /// Example: &lt;p&gt;Hello {{{FIRST_NAME|there}}}!&lt;/p&gt;
        /// </param>
        /// <param name="topicId">
        /// The topic ID that the broadcast is scoped to.<br/>
        /// Example: b6d24b8e-af0b-4c3c-be0c-359bbd97381e
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBroadcastResponseSuccess(
            string? id,
            string? name,
            string? segmentId,
            string? from,
            string? subject,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? previewText,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? scheduledAt,
            global::System.DateTime? sentAt,
            string? text,
            string? html,
            string? topicId)
        {
            this.Id = id;
            this.Name = name;
            this.SegmentId = segmentId;
            this.From = from;
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.PreviewText = previewText;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ScheduledAt = scheduledAt;
            this.SentAt = sentAt;
            this.Text = text;
            this.Html = html;
            this.TopicId = topicId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBroadcastResponseSuccess" /> class.
        /// </summary>
        public GetBroadcastResponseSuccess()
        {
        }
    }
}