
#nullable enable

namespace Resend
{
    /// <summary>
    /// The data of an `inbox.thread.assigned` event.
    /// </summary>
    public sealed partial class InboxThreadAssignedEventData
    {
        /// <summary>
        /// The email of the member the thread is now assigned to.<br/>
        /// Example: ada@acme.com
        /// </summary>
        /// <example>ada@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_email")]
        public string? AssigneeEmail { get; set; }

        /// <summary>
        /// The email of the member who made the assignment. Null when no member made it.<br/>
        /// Example: grace@acme.com
        /// </summary>
        /// <example>grace@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_by_email")]
        public string? AssignedByEmail { get; set; }

        /// <summary>
        /// The email of the member the thread was assigned to before. Null when it was unassigned.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_assignee_email")]
        public string? PreviousAssigneeEmail { get; set; }

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
        /// Initializes a new instance of the <see cref="InboxThreadAssignedEventData" /> class.
        /// </summary>
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
        /// <param name="assigneeEmail">
        /// The email of the member the thread is now assigned to.<br/>
        /// Example: ada@acme.com
        /// </param>
        /// <param name="assignedByEmail">
        /// The email of the member who made the assignment. Null when no member made it.<br/>
        /// Example: grace@acme.com
        /// </param>
        /// <param name="previousAssigneeEmail">
        /// The email of the member the thread was assigned to before. Null when it was unassigned.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="thread">
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadAssignedEventData(
            global::Resend.InboxEventSource source,
            global::System.Guid inboxId,
            global::System.Guid threadId,
            string? assigneeEmail,
            string? assignedByEmail,
            string? previousAssigneeEmail,
            global::Resend.InboxThreadSummary? thread)
        {
            this.AssigneeEmail = assigneeEmail;
            this.AssignedByEmail = assignedByEmail;
            this.PreviousAssigneeEmail = previousAssigneeEmail;
            this.Source = source;
            this.InboxId = inboxId;
            this.ThreadId = threadId;
            this.Thread = thread;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadAssignedEventData" /> class.
        /// </summary>
        public InboxThreadAssignedEventData()
        {
        }

    }
}