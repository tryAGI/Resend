
#nullable enable

namespace Resend
{
    /// <summary>
    /// The draft carried by an inbox webhook event. It has no `html` or `text`.
    /// </summary>
    public sealed partial class InboxEventDraft
    {
        /// <summary>
        /// The object type. Always `inbox_draft`.<br/>
        /// Example: inbox_draft
        /// </summary>
        /// <example>inbox_draft</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the draft.<br/>
        /// Example: 9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d
        /// </summary>
        /// <example>9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// `standalone` for a new conversation, or `reply`.<br/>
        /// Example: reply
        /// </summary>
        /// <example>reply</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxEventDraftTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxEventDraftType Type { get; set; }

        /// <summary>
        /// The recipients.<br/>
        /// Example: [steve@acme.com]
        /// </summary>
        /// <example>[steve@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.Collections.Generic.IList<string>? To { get; set; }

        /// <summary>
        /// The CC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// The BCC recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// The subject.<br/>
        /// Example: Re: Question about my invoice
        /// </summary>
        /// <example>Re: Question about my invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The ID of the thread when this draft is a reply. Null otherwise.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </summary>
        /// <example>7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// The ID of the email this draft replies to. Null otherwise.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </summary>
        /// <example>4ef9a417-02e9-4d39-ad75-9611e0fcc33c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to_email_id")]
        public global::System.Guid? ReplyToEmailId { get; set; }

        /// <summary>
        /// The ID of the queued outbound email after send. Null until then.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        public global::System.Guid? EmailId { get; set; }

        /// <summary>
        /// Timestamp when the draft was created.<br/>
        /// Example: 2026-09-29T11:58:00.000Z
        /// </summary>
        /// <example>2026-09-29T11:58:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the draft was last saved.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </summary>
        /// <example>2026-09-29T12:00:00.000Z</example>
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
        /// Initializes a new instance of the <see cref="InboxEventDraft" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type. Always `inbox_draft`.<br/>
        /// Example: inbox_draft
        /// </param>
        /// <param name="id">
        /// The ID of the draft.<br/>
        /// Example: 9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d
        /// </param>
        /// <param name="type">
        /// `standalone` for a new conversation, or `reply`.<br/>
        /// Example: reply
        /// </param>
        /// <param name="cc">
        /// The CC recipients.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the draft was created.<br/>
        /// Example: 2026-09-29T11:58:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the draft was last saved.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </param>
        /// <param name="attachments">
        /// The files stored on the draft.
        /// </param>
        /// <param name="to">
        /// The recipients.<br/>
        /// Example: [steve@acme.com]
        /// </param>
        /// <param name="subject">
        /// The subject.<br/>
        /// Example: Re: Question about my invoice
        /// </param>
        /// <param name="threadId">
        /// The ID of the thread when this draft is a reply. Null otherwise.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </param>
        /// <param name="replyToEmailId">
        /// The ID of the email this draft replies to. Null otherwise.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </param>
        /// <param name="emailId">
        /// The ID of the queued outbound email after send. Null until then.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxEventDraft(
            string @object,
            global::System.Guid id,
            global::Resend.InboxEventDraftType type,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachment> attachments,
            global::System.Collections.Generic.IList<string>? to,
            string? subject,
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
            this.ThreadId = threadId;
            this.ReplyToEmailId = replyToEmailId;
            this.EmailId = emailId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventDraft" /> class.
        /// </summary>
        public InboxEventDraft()
        {
        }

    }
}