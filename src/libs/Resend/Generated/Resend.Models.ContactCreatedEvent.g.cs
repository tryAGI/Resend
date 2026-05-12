
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactCreatedEvent
    {
        /// <summary>
        /// The event type.
        /// </summary>
        /// <default>"contact.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "contact.created";

        /// <summary>
        /// Timestamp when the event was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.ContactEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCreatedEvent" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp when the event was emitted.
        /// </param>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactCreatedEvent(
            global::System.DateTime createdAt,
            global::Resend.ContactEventData data,
            string type = "contact.created")
        {
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCreatedEvent" /> class.
        /// </summary>
        public ContactCreatedEvent()
        {
        }

    }
}