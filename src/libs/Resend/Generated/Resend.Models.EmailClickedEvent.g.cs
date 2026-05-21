
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailClickedEvent
    {
        /// <summary>
        /// The event type.
        /// </summary>
        /// <default>"email.clicked"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "email.clicked";

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.EmailClickedEventDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.EmailClickedEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClickedEvent" /> class.
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
        public EmailClickedEvent(
            global::System.DateTime createdAt,
            global::Resend.EmailClickedEventData data,
            string type = "email.clicked")
        {
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClickedEvent" /> class.
        /// </summary>
        public EmailClickedEvent()
        {
        }

    }
}