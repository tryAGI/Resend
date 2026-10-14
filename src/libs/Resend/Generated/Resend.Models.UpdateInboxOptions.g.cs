
#nullable enable

namespace Resend
{
    /// <summary>
    /// Provide at least one of `name` or `from_name`.
    /// </summary>
    public sealed partial class UpdateInboxOptions
    {
        /// <summary>
        /// New internal name for the inbox. Recipients do not see it. Between 1 and 64 characters after trimming.<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string removes it.<br/>
        /// Example: Ada from Support
        /// </summary>
        /// <example>Ada from Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        public string? FromName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// New internal name for the inbox. Recipients do not see it. Between 1 and 64 characters after trimming.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="fromName">
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string removes it.<br/>
        /// Example: Ada from Support
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxOptions(
            string? name,
            string? fromName)
        {
            this.Name = name;
            this.FromName = fromName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxOptions" /> class.
        /// </summary>
        public UpdateInboxOptions()
        {
        }

    }
}