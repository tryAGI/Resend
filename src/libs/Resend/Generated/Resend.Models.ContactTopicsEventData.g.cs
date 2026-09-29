
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactTopicsEventData
    {
        /// <summary>
        /// Contact's email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Topics whose subscription changed in this update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.ContactTopicsEventDataTopic> Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactTopicsEventData" /> class.
        /// </summary>
        /// <param name="email">
        /// Contact's email address.
        /// </param>
        /// <param name="topics">
        /// Topics whose subscription changed in this update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactTopicsEventData(
            string email,
            global::System.Collections.Generic.IList<global::Resend.ContactTopicsEventDataTopic> topics)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Topics = topics ?? throw new global::System.ArgumentNullException(nameof(topics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactTopicsEventData" /> class.
        /// </summary>
        public ContactTopicsEventData()
        {
        }

    }
}