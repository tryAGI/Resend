
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxDraft
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: inbox_draft
        /// </summary>
        /// <example>inbox_draft</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the draft.<br/>
        /// Example: c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32
        /// </summary>
        /// <example>c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// `reply` when the draft replies to an email in an existing thread. `standalone` when the draft starts a new thread.<br/>
        /// Example: standalone
        /// </summary>
        /// <example>standalone</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxDraftTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxDraftType Type { get; set; }

        /// <summary>
        /// The recipients. `null` or empty when no recipients are set.<br/>
        /// Example: [ada@example.org]
        /// </summary>
        /// <example>[ada@example.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.Collections.Generic.IList<string>? To { get; set; }

        /// <summary>
        /// The CC recipients.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// The BCC recipients.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// The subject.<br/>
        /// Example: Refund for order 1041
        /// </summary>
        /// <example>Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Refund issued for order 1041.&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text body. A reply draft created without a body has an empty string.<br/>
        /// Example: Refund issued for order 1041.
        /// </summary>
        /// <example>Refund issued for order 1041.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The Thread ID when the draft is a reply. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// The Email ID the draft replies to. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to_email_id")]
        public global::System.Guid? ReplyToEmailId { get; set; }

        /// <summary>
        /// The ID of the outbound email queued when the draft was sent. `null` until the draft is sent.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        public global::System.Guid? EmailId { get; set; }

        /// <summary>
        /// Timestamp when the draft was created.<br/>
        /// Example: 2026-08-05T14:12:04.110Z
        /// </summary>
        /// <example>2026-08-05T14:12:04.110Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the draft was last saved.<br/>
        /// Example: 2026-08-05T14:12:04.110Z
        /// </summary>
        /// <example>2026-08-05T14:12:04.110Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The files stored on the draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachment> Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraft" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: inbox_draft
        /// </param>
        /// <param name="id">
        /// The ID of the draft.<br/>
        /// Example: c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32
        /// </param>
        /// <param name="type">
        /// `reply` when the draft replies to an email in an existing thread. `standalone` when the draft starts a new thread.<br/>
        /// Example: standalone
        /// </param>
        /// <param name="cc">
        /// The CC recipients.<br/>
        /// Example: []
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients.<br/>
        /// Example: []
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the draft was created.<br/>
        /// Example: 2026-08-05T14:12:04.110Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the draft was last saved.<br/>
        /// Example: 2026-08-05T14:12:04.110Z
        /// </param>
        /// <param name="attachments">
        /// The files stored on the draft.
        /// </param>
        /// <param name="to">
        /// The recipients. `null` or empty when no recipients are set.<br/>
        /// Example: [ada@example.org]
        /// </param>
        /// <param name="subject">
        /// The subject.<br/>
        /// Example: Refund for order 1041
        /// </param>
        /// <param name="html">
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain text body. A reply draft created without a body has an empty string.<br/>
        /// Example: Refund issued for order 1041.
        /// </param>
        /// <param name="threadId">
        /// The Thread ID when the draft is a reply. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replyToEmailId">
        /// The Email ID the draft replies to. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="emailId">
        /// The ID of the outbound email queued when the draft was sent. `null` until the draft is sent.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraft(
            string @object,
            global::System.Guid id,
            global::Resend.InboxDraftType type,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachment> attachments,
            global::System.Collections.Generic.IList<string>? to,
            string? subject,
            string? html,
            string? text,
            global::System.Guid? threadId,
            global::System.Guid? replyToEmailId,
            global::System.Guid? emailId)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Type = type;
            this.To = to;
            this.Cc = cc ?? throw new global::System.ArgumentNullException(nameof(cc));
            this.Bcc = bcc ?? throw new global::System.ArgumentNullException(nameof(bcc));
            this.Subject = subject;
            this.Html = html;
            this.Text = text;
            this.ThreadId = threadId;
            this.ReplyToEmailId = replyToEmailId;
            this.EmailId = emailId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraft" /> class.
        /// </summary>
        public InboxDraft()
        {
        }

    }
}