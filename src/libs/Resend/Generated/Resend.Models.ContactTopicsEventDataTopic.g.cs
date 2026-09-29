
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactTopicsEventDataTopic
    {
        /// <summary>
        /// Unique identifier for the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The new subscription status for this topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ContactTopicsEventDataTopicSubscriptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.ContactTopicsEventDataTopicSubscription Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactTopicsEventDataTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the topic.
        /// </param>
        /// <param name="subscription">
        /// The new subscription status for this topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactTopicsEventDataTopic(
            string id,
            global::Resend.ContactTopicsEventDataTopicSubscription subscription)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactTopicsEventDataTopic" /> class.
        /// </summary>
        public ContactTopicsEventDataTopic()
        {
        }

    }
}