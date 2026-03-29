
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTopicResponseSuccess
    {
        /// <summary>
        /// The ID of the topic.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Example: topic
        /// </summary>
        /// <example>topic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The name of the topic.<br/>
        /// Example: Newsletter
        /// </summary>
        /// <example>Newsletter</example>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetTopicResponseSuccessDefaultSubscriptionJsonConverter))]
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? DefaultSubscription { get; set; }

        /// <summary>
        /// The visibility of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetTopicResponseSuccessVisibilityJsonConverter))]
        public global::Resend.GetTopicResponseSuccessVisibility? Visibility { get; set; }

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
        /// Initializes a new instance of the <see cref="GetTopicResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the topic.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: topic
        /// </param>
        /// <param name="name">
        /// The name of the topic.<br/>
        /// Example: Newsletter
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
        public GetTopicResponseSuccess(
            string? id,
            string? @object,
            string? name,
            string? description,
            global::Resend.GetTopicResponseSuccessDefaultSubscription? defaultSubscription,
            global::Resend.GetTopicResponseSuccessVisibility? visibility,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Object = @object;
            this.Name = name;
            this.Description = description;
            this.DefaultSubscription = defaultSubscription;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTopicResponseSuccess" /> class.
        /// </summary>
        public GetTopicResponseSuccess()
        {
        }
    }
}