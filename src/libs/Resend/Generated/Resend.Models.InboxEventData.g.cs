
#nullable enable

namespace Resend
{
    /// <summary>
    /// The data of an `inbox.created` or `inbox.updated` event.
    /// </summary>
    public sealed partial class InboxEventData
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
        /// The inbox as it is when the webhook is sent. Absent when the inbox no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbox")]
        public global::Resend.Inbox? Inbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventData" /> class.
        /// </summary>
        /// <param name="source">
        /// What made the change.<br/>
        /// Example: dashboard
        /// </param>
        /// <param name="inboxId">
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </param>
        /// <param name="inbox">
        /// The inbox as it is when the webhook is sent. Absent when the inbox no longer exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxEventData(
            global::Resend.InboxEventSource source,
            global::System.Guid inboxId,
            global::Resend.Inbox? inbox)
        {
            this.Source = source;
            this.InboxId = inboxId;
            this.Inbox = inbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventData" /> class.
        /// </summary>
        public InboxEventData()
        {
        }

    }
}