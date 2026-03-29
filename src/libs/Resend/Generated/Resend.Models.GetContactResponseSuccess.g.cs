
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContactResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: contact
        /// </summary>
        /// <example>contact</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the contact.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Timestamp indicating when the contact was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Indicates if the contact is unsubscribed.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsubscribed")]
        public bool? Unsubscribed { get; set; }

        /// <summary>
        /// A map of custom property keys and values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: contact
        /// </param>
        /// <param name="id">
        /// Unique identifier for the contact.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
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
        /// <param name="createdAt">
        /// Timestamp indicating when the contact was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="unsubscribed">
        /// Indicates if the contact is unsubscribed.<br/>
        /// Example: false
        /// </param>
        /// <param name="properties">
        /// A map of custom property keys and values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContactResponseSuccess(
            string? @object,
            string? id,
            string? email,
            string? firstName,
            string? lastName,
            global::System.DateTime? createdAt,
            bool? unsubscribed,
            object? properties)
        {
            this.Object = @object;
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CreatedAt = createdAt;
            this.Unsubscribed = unsubscribed;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactResponseSuccess" /> class.
        /// </summary>
        public GetContactResponseSuccess()
        {
        }
    }
}