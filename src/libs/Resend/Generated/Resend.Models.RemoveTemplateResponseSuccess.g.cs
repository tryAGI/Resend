
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveTemplateResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: template
        /// </summary>
        /// <example>template</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates whether the template was successfully deleted.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveTemplateResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: template
        /// </param>
        /// <param name="id">
        /// The ID of the template.
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the template was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveTemplateResponseSuccess(
            string? @object,
            string? id,
            bool? deleted)
        {
            this.Object = @object;
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTemplateResponseSuccess" /> class.
        /// </summary>
        public RemoveTemplateResponseSuccess()
        {
        }
    }
}