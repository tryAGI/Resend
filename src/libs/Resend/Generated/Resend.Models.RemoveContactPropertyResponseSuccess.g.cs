
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveContactPropertyResponseSuccess
    {
        /// <summary>
        /// The ID of the contact property.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Example: contact_property
        /// </summary>
        /// <example>contact_property</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Indicates whether the contact property was successfully deleted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactPropertyResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the contact property.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: contact_property
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the contact property was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveContactPropertyResponseSuccess(
            string? id,
            string? @object,
            bool? deleted)
        {
            this.Id = id;
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactPropertyResponseSuccess" /> class.
        /// </summary>
        public RemoveContactPropertyResponseSuccess()
        {
        }
    }
}