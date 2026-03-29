
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactTopicsResponseSuccess
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: contact_topics
        /// </summary>
        /// <example>contact_topics</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public string? ContactId { get; set; }

        /// <summary>
        /// Array of updated topic subscriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: contact_topics
        /// </param>
        /// <param name="contactId">
        /// The ID of the contact.
        /// </param>
        /// <param name="topics">
        /// Array of updated topic subscriptions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactTopicsResponseSuccess(
            string? @object,
            string? contactId,
            global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? topics)
        {
            this.Object = @object;
            this.ContactId = contactId;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsResponseSuccess" /> class.
        /// </summary>
        public UpdateContactTopicsResponseSuccess()
        {
        }
    }
}