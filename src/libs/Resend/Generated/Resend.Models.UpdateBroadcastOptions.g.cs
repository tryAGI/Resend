
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBroadcastOptions
    {
        /// <summary>
        /// Name of the broadcast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Use `segment_id` instead. Unique identifier of the audience this broadcast will be sent to.
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
        /// The email address of the sender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The subject line of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The email addresses to which replies should be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// The preview text of the email.
        /// </summary>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBroadcastOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the broadcast.
        /// </param>
        /// <param name="segmentId">
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </param>
        /// <param name="from">
        /// The email address of the sender.
        /// </param>
        /// <param name="subject">
        /// The subject line of the email.
        /// </param>
        /// <param name="replyTo">
        /// The email addresses to which replies should be sent.
        /// </param>
        /// <param name="previewText">
        /// The preview text of the email.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBroadcastOptions(
            string? name,
            string? segmentId,
            string? from,
            string? subject,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? previewText,
            string? html,
            string? text,
            string? topicId)
        {
            this.Name = name;
            this.SegmentId = segmentId;
            this.From = from;
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.PreviewText = previewText;
            this.Html = html;
            this.Text = text;
            this.TopicId = topicId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBroadcastOptions" /> class.
        /// </summary>
        public UpdateBroadcastOptions()
        {
        }
    }
}