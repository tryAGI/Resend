
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TopicEventData
    {
        /// <summary>
        /// Unique identifier for the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The default subscription status for the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.TopicEventDataDefaultSubscriptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.TopicEventDataDefaultSubscription DefaultSubscription { get; set; }

        /// <summary>
        /// Whether the topic has been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Timestamp when the topic was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the topic was last updated.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the topic.
        /// </param>
        /// <param name="name">
        /// The name of the topic.
        /// </param>
        /// <param name="defaultSubscription">
        /// The default subscription status for the topic.
        /// </param>
        /// <param name="deleted">
        /// Whether the topic has been deleted.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the topic was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the topic was last updated.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="description">
        /// A description of the topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicEventData(
            string id,
            string name,
            global::Resend.TopicEventDataDefaultSubscription defaultSubscription,
            bool deleted,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DefaultSubscription = defaultSubscription;
            this.Deleted = deleted;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicEventData" /> class.
        /// </summary>
        public TopicEventData()
        {
        }

    }
}