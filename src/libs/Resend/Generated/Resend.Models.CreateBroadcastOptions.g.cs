
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBroadcastOptions
    {
        /// <summary>
        /// Name of the broadcast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentId { get; set; }

        /// <summary>
        /// Use `segment_id` instead. Unique identifier of the segment this broadcast will be sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// The email address of the sender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The subject line of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

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
        /// The topic ID that the broadcast will be scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// Whether to send the broadcast immediately or keep it as a draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send")]
        public bool? Send { get; set; }

        /// <summary>
        /// Schedule time to send the broadcast. Can only be used if `send` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public string? ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBroadcastOptions" /> class.
        /// </summary>
        /// <param name="segmentId">
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </param>
        /// <param name="from">
        /// The email address of the sender.
        /// </param>
        /// <param name="subject">
        /// The subject line of the email.
        /// </param>
        /// <param name="name">
        /// Name of the broadcast.
        /// </param>
        /// <param name="replyTo">
        /// The email addresses to which replies should be sent.
        /// </param>
        /// <param name="previewText">
        /// The preview text of the email.<br/>
        /// Example: Here are our announcements
        /// </param>
        /// <param name="html">
        /// The HTML version of the message.
        /// </param>
        /// <param name="text">
        /// The plain text version of the message.
        /// </param>
        /// <param name="topicId">
        /// The topic ID that the broadcast will be scoped to.
        /// </param>
        /// <param name="send">
        /// Whether to send the broadcast immediately or keep it as a draft.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule time to send the broadcast. Can only be used if `send` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBroadcastOptions(
            string segmentId,
            string from,
            string subject,
            string? name,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? previewText,
            string? html,
            string? text,
            string? topicId,
            bool? send,
            string? scheduledAt)
        {
            this.Name = name;
            this.SegmentId = segmentId ?? throw new global::System.ArgumentNullException(nameof(segmentId));
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.ReplyTo = replyTo;
            this.PreviewText = previewText;
            this.Html = html;
            this.Text = text;
            this.TopicId = topicId;
            this.Send = send;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBroadcastOptions" /> class.
        /// </summary>
        public CreateBroadcastOptions()
        {
        }
    }
}