
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContactOptions
    {
        /// <summary>
        /// Email address of the contact.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </summary>
        /// <example>steve.wozniak@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// First name of the contact.<br/>
        /// Example: Steve
        /// </summary>
        /// <example>Steve</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the contact.<br/>
        /// Example: Wozniak
        /// </summary>
        /// <example>Wozniak</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// The Contact's global subscription status. If set to true, the contact will be unsubscribed from all Broadcasts.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsubscribed")]
        public bool? Unsubscribed { get; set; }

        /// <summary>
        /// A map of custom property keys and values to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Array of segment IDs to add the contact to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<string>? Segments { get; set; }

        /// <summary>
        /// Array of topic subscriptions for the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Topics { get; set; }

        /// <summary>
        /// Unique identifier of the audience to which the contact belongs.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactOptions" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address of the contact.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </param>
        /// <param name="firstName">
        /// First name of the contact.<br/>
        /// Example: Steve
        /// </param>
        /// <param name="lastName">
        /// Last name of the contact.<br/>
        /// Example: Wozniak
        /// </param>
        /// <param name="unsubscribed">
        /// The Contact's global subscription status. If set to true, the contact will be unsubscribed from all Broadcasts.<br/>
        /// Example: false
        /// </param>
        /// <param name="properties">
        /// A map of custom property keys and values to create.
        /// </param>
        /// <param name="segments">
        /// Array of segment IDs to add the contact to.
        /// </param>
        /// <param name="topics">
        /// Array of topic subscriptions for the contact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactOptions(
            string email,
            string? firstName,
            string? lastName,
            bool? unsubscribed,
            object? properties,
            global::System.Collections.Generic.IList<string>? segments,
            global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? topics)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Unsubscribed = unsubscribed;
            this.Properties = properties;
            this.Segments = segments;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactOptions" /> class.
        /// </summary>
        public CreateContactOptions()
        {
        }
    }
}