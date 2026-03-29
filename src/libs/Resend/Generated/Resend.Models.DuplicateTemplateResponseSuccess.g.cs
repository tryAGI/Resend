
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DuplicateTemplateResponseSuccess
    {
        /// <summary>
        /// The ID of the duplicated template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type of the response.<br/>
        /// Example: template
        /// </summary>
        /// <example>template</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateTemplateResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the duplicated template.
        /// </param>
        /// <param name="object">
        /// The object type of the response.<br/>
        /// Example: template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuplicateTemplateResponseSuccess(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateTemplateResponseSuccess" /> class.
        /// </summary>
        public DuplicateTemplateResponseSuccess()
        {
        }
    }
}