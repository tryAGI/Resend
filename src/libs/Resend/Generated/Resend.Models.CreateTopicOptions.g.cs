
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTopicOptions
    {
        /// <summary>
        /// The name of the topic. Max 50 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The default subscription status for the topic. Cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateTopicOptionsDefaultSubscriptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.CreateTopicOptionsDefaultSubscription DefaultSubscription { get; set; }

        /// <summary>
        /// A description of the topic. Max 200 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The visibility of the topic. Public topics are visible to all contacts on the unsubscribe page. Private topics are only visible to opted-in contacts.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateTopicOptionsVisibilityJsonConverter))]
        public global::Resend.CreateTopicOptionsVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTopicOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. Max 50 characters.
        /// </param>
        /// <param name="defaultSubscription">
        /// The default subscription status for the topic. Cannot be changed after creation.
        /// </param>
        /// <param name="description">
        /// A description of the topic. Max 200 characters.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the topic. Public topics are visible to all contacts on the unsubscribe page. Private topics are only visible to opted-in contacts.<br/>
        /// Default Value: private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTopicOptions(
            string name,
            global::Resend.CreateTopicOptionsDefaultSubscription defaultSubscription,
            string? description,
            global::Resend.CreateTopicOptionsVisibility? visibility)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultSubscription = defaultSubscription;
            this.Description = description;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTopicOptions" /> class.
        /// </summary>
        public CreateTopicOptions()
        {
        }
    }
}