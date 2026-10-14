
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxDraftUpdatedEvent
    {
        /// <summary>
        /// The event type.
        /// </summary>
        /// <default>"inbox.draft.updated"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "inbox.draft.updated";

        /// <summary>
        /// Timestamp when the event was emitted.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </summary>
        /// <example>2026-09-29T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The data of an `inbox.draft.created`, `inbox.draft.updated` or `inbox.draft.deleted` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxDraftEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftUpdatedEvent" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp when the event was emitted.<br/>
        /// Example: 2026-09-29T12:00:00.000Z
        /// </param>
        /// <param name="data">
        /// The data of an `inbox.draft.created`, `inbox.draft.updated` or `inbox.draft.deleted` event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraftUpdatedEvent(
            global::System.DateTime createdAt,
            global::Resend.InboxDraftEventData data,
            string type = "inbox.draft.updated")
        {
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftUpdatedEvent" /> class.
        /// </summary>
        public InboxDraftUpdatedEvent()
        {
        }

    }
}