
#nullable enable

namespace Resend
{
    /// <summary>
    /// The data of an `inbox.thread.labels.updated` event. One event carries one label, in either `added` or `removed`.
    /// </summary>
    public sealed partial class InboxThreadLabelsUpdatedEventData
    {
        /// <summary>
        /// The labels applied to the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> Added { get; set; }

        /// <summary>
        /// The labels removed from the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> Removed { get; set; }

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
        /// The ID of the thread.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </summary>
        /// <example>7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ThreadId { get; set; }

        /// <summary>
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread")]
        public global::Resend.InboxThreadSummary? Thread { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadLabelsUpdatedEventData" /> class.
        /// </summary>
        /// <param name="added">
        /// The labels applied to the thread.
        /// </param>
        /// <param name="removed">
        /// The labels removed from the thread.
        /// </param>
        /// <param name="source">
        /// What made the change.<br/>
        /// Example: dashboard
        /// </param>
        /// <param name="inboxId">
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </param>
        /// <param name="threadId">
        /// The ID of the thread.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </param>
        /// <param name="thread">
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadLabelsUpdatedEventData(
            global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> added,
            global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> removed,
            global::Resend.InboxEventSource source,
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::Resend.InboxThreadSummary? thread)
        {
            this.Added = added ?? throw new global::System.ArgumentNullException(nameof(added));
            this.Removed = removed ?? throw new global::System.ArgumentNullException(nameof(removed));
            this.Source = source;
            this.InboxId = inboxId;
            this.ThreadId = threadId;
            this.Thread = thread;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadLabelsUpdatedEventData" /> class.
        /// </summary>
        public InboxThreadLabelsUpdatedEventData()
        {
        }

    }
}