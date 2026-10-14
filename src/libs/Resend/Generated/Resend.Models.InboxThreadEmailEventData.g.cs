
#nullable enable

namespace Resend
{
    /// <summary>
    /// The data of an `inbox.thread.created`, `inbox.email.received` or `inbox.email.sent` event.
    /// </summary>
    public sealed partial class InboxThreadEmailEventData
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
        /// The ID of the thread.<br/>
        /// Example: 7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90
        /// </summary>
        /// <example>7c1f0a2e-5d3b-4e8a-9f61-2b8d4c6e1a90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ThreadId { get; set; }

        /// <summary>
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </summary>
        /// <example>4ef9a417-02e9-4d39-ad75-9611e0fcc33c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EmailId { get; set; }

        /// <summary>
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread")]
        public global::Resend.InboxThreadSummary? Thread { get; set; }

        /// <summary>
        /// The email as it is when the webhook is sent, without `html` or `text`. Fetch the body with Retrieve Thread Email. Absent when the email no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public global::Resend.InboxEventEmail? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmailEventData" /> class.
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
        /// <param name="emailId">
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </param>
        /// <param name="thread">
        /// The thread as it is when the webhook is sent. Absent when the thread no longer exists.
        /// </param>
        /// <param name="email">
        /// The email as it is when the webhook is sent, without `html` or `text`. Fetch the body with Retrieve Thread Email. Absent when the email no longer exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadEmailEventData(
            global::Resend.InboxEventSource source,
            global::System.Guid inboxId,
            global::System.Guid threadId,
            global::System.Guid emailId,
            global::Resend.InboxThreadSummary? thread,
            global::Resend.InboxEventEmail? email)
        {
            this.Source = source;
            this.InboxId = inboxId;
            this.ThreadId = threadId;
            this.EmailId = emailId;
            this.Thread = thread;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmailEventData" /> class.
        /// </summary>
        public InboxThreadEmailEventData()
        {
        }

    }
}