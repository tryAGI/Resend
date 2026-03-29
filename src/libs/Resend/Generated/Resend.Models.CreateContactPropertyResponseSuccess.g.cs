
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContactPropertyResponseSuccess
    {
        /// <summary>
        /// The ID of the contact property.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type of the response.<br/>
        /// Example: contact_property
        /// </summary>
        /// <example>contact_property</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the contact property.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object type of the response.<br/>
        /// Example: contact_property
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactPropertyResponseSuccess(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyResponseSuccess" /> class.
        /// </summary>
        public CreateContactPropertyResponseSuccess()
        {
        }
    }
}