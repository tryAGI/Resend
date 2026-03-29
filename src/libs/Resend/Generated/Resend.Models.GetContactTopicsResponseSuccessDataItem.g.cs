
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContactTopicsResponseSuccessDataItem
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
        /// Description of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The subscription status for this topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetContactTopicsResponseSuccessDataItemSubscriptionJsonConverter))]
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactTopicsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the topic.
        /// </param>
        /// <param name="name">
        /// Name of the topic.
        /// </param>
        /// <param name="description">
        /// Description of the topic.
        /// </param>
        /// <param name="subscription">
        /// The subscription status for this topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContactTopicsResponseSuccessDataItem(
            string? id,
            string? name,
            string? description,
            global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? subscription)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactTopicsResponseSuccessDataItem" /> class.
        /// </summary>
        public GetContactTopicsResponseSuccessDataItem()
        {
        }
    }
}