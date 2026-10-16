
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateInboxOptions
    {
        /// <summary>
        /// The inbox email address on one of your domains. The API trims and lowercases it. The part before the `@` is at most 64 characters and contains only letters, numbers, and `. _ % -`. A `+` returns a 422. It cannot start or end with a dot or contain two dots in a row.<br/>
        /// Example: support@acme.com
        /// </summary>
        /// <example>support@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// Internal name for the inbox. Recipients do not see it. Max 64 characters. Defaults to `email_address`.<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string leaves it unset.<br/>
        /// Example: Ada from Support
        /// </summary>
        /// <example>Ada from Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        public string? FromName { get; set; }

        /// <summary>
        /// When `true`, Resend provisions a receiving address so you can receive mail without adding an MX record. The address is returned in `receiving_address`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwarding")]
        public bool? Forwarding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxOptions" /> class.
        /// </summary>
        /// <param name="emailAddress">
        /// The inbox email address on one of your domains. The API trims and lowercases it. The part before the `@` is at most 64 characters and contains only letters, numbers, and `. _ % -`. A `+` returns a 422. It cannot start or end with a dot or contain two dots in a row.<br/>
        /// Example: support@acme.com
        /// </param>
        /// <param name="name">
        /// Internal name for the inbox. Recipients do not see it. Max 64 characters. Defaults to `email_address`.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="fromName">
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string leaves it unset.<br/>
        /// Example: Ada from Support
        /// </param>
        /// <param name="forwarding">
        /// When `true`, Resend provisions a receiving address so you can receive mail without adding an MX record. The address is returned in `receiving_address`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInboxOptions(
            string emailAddress,
            string? name,
            string? fromName,
            bool? forwarding)
        {
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.Name = name;
            this.FromName = fromName;
            this.Forwarding = forwarding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxOptions" /> class.
        /// </summary>
        public CreateInboxOptions()
        {
        }

    }
}