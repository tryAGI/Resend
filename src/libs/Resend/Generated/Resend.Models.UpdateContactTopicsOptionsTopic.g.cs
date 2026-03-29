
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactTopicsOptionsTopic
    {
        /// <summary>
        /// The ID of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The subscription status (opt_in or opt_out).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateContactTopicsOptionsTopicSubscriptionJsonConverter))]
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsOptionsTopic" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the topic.
        /// </param>
        /// <param name="subscription">
        /// The subscription status (opt_in or opt_out).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactTopicsOptionsTopic(
            string? id,
            global::Resend.UpdateContactTopicsOptionsTopicSubscription? subscription)
        {
            this.Id = id;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsOptionsTopic" /> class.
        /// </summary>
        public UpdateContactTopicsOptionsTopic()
        {
        }
    }
}