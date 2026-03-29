
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTopicsResponseSuccessDataItem
    {
        /// <summary>
        /// Unique identifier for the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The default subscription status for the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemDefaultSubscriptionJsonConverter))]
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? DefaultSubscription { get; set; }

        /// <summary>
        /// The visibility of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemVisibilityJsonConverter))]
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Visibility { get; set; }

        /// <summary>
        /// Timestamp indicating when the topic was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTopicsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the topic.
        /// </param>
        /// <param name="name">
        /// Name of the topic.
        /// </param>
        /// <param name="description">
        /// A description of the topic.
        /// </param>
        /// <param name="defaultSubscription">
        /// The default subscription status for the topic.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the topic.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the topic was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTopicsResponseSuccessDataItem(
            string? id,
            string? name,
            string? description,
            global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? defaultSubscription,
            global::Resend.ListTopicsResponseSuccessDataItemVisibility? visibility,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DefaultSubscription = defaultSubscription;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTopicsResponseSuccessDataItem" /> class.
        /// </summary>
        public ListTopicsResponseSuccessDataItem()
        {
        }
    }
}