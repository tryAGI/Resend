
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactTopicsResponseSuccessTopic
    {
        /// <summary>
        /// The ID of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The subscription status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateContactTopicsResponseSuccessTopicSubscriptionJsonConverter))]
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsResponseSuccessTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the topic.
        /// </param>
        /// <param name="subscription">
        /// The subscription status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactTopicsResponseSuccessTopic(
            string? id,
            global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? subscription)
        {
            this.Id = id;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsResponseSuccessTopic" /> class.
        /// </summary>
        public UpdateContactTopicsResponseSuccessTopic()
        {
        }
    }
}