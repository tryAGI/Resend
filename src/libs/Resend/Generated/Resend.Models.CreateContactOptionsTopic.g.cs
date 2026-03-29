
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContactOptionsTopic
    {
        /// <summary>
        /// The topic ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The subscription status for this topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateContactOptionsTopicSubscriptionJsonConverter))]
        public global::Resend.CreateContactOptionsTopicSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactOptionsTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// The topic ID.
        /// </param>
        /// <param name="subscription">
        /// The subscription status for this topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactOptionsTopic(
            string? id,
            global::Resend.CreateContactOptionsTopicSubscription? subscription)
        {
            this.Id = id;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactOptionsTopic" /> class.
        /// </summary>
        public CreateContactOptionsTopic()
        {
        }
    }
}