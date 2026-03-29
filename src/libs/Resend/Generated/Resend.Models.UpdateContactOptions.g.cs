
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactOptions
    {
        /// <summary>
        /// Email address of the contact.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </summary>
        /// <example>steve.wozniak@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

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
        /// A map of custom property keys and values to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactOptions" /> class.
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
        /// A map of custom property keys and values to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactOptions(
            string? email,
            string? firstName,
            string? lastName,
            bool? unsubscribed,
            object? properties)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Unsubscribed = unsubscribed;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactOptions" /> class.
        /// </summary>
        public UpdateContactOptions()
        {
        }
    }
}