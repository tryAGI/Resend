
#nullable enable

namespace Resend
{
    /// <summary>
    /// The data of an `inbox.draft.created`, `inbox.draft.updated` or `inbox.draft.deleted` event.
    /// </summary>
    public sealed partial class InboxDraftEventData
    {
        /// <summary>
        /// What made the change.<br/>
        /// Example: dashboard
        /// </summary>
        /// <example>dashboard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxEventSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxEventSource Source { get; set; }

        /// <summary>
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </summary>
        /// <example>b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InboxId { get; set; }

        /// <summary>
        /// The ID of the thread. Only on reply drafts.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </summary>
        /// <example>7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// The ID of the draft.<br/>
        /// Example: 9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d
        /// </summary>
        /// <example>9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DraftId { get; set; }

        /// <summary>
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists. Only on reply drafts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread")]
        public global::Resend.InboxThreadSummary? Thread { get; set; }

        /// <summary>
        /// The draft as it is when the webhook is sent, without `html` or `text`. Fetch the body with Retrieve Draft. Absent when the draft no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public global::Resend.InboxEventDraft? Draft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftEventData" /> class.
        /// </summary>
        /// <param name="source">
        /// What made the change.<br/>
        /// Example: dashboard
        /// </param>
        /// <param name="inboxId">
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </param>
        /// <param name="draftId">
        /// The ID of the draft.<br/>
        /// Example: 9a2b7c4d-1e3f-4a5b-8c6d-0e1f2a3b4c5d
        /// </param>
        /// <param name="threadId">
        /// The ID of the thread. Only on reply drafts.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </param>
        /// <param name="thread">
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists. Only on reply drafts.
        /// </param>
        /// <param name="draft">
        /// The draft as it is when the webhook is sent, without `html` or `text`. Fetch the body with Retrieve Draft. Absent when the draft no longer exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraftEventData(
            global::Resend.InboxEventSource source,
            global::System.Guid inboxId,
            global::System.Guid draftId,
            global::System.Guid? threadId,
            global::Resend.InboxThreadSummary? thread,
            global::Resend.InboxEventDraft? draft)
        {
            this.Source = source;
            this.InboxId = inboxId;
            this.ThreadId = threadId;
            this.DraftId = draftId;
            this.Thread = thread;
            this.Draft = draft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftEventData" /> class.
        /// </summary>
        public InboxDraftEventData()
        {
        }

    }
}