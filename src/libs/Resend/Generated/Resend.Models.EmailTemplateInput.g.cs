
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailTemplateInput
    {
        /// <summary>
        /// The id of the published email template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Template variables object with key/value pairs.<br/>
        /// Example: {"variableName":"Sign up now","variableName2":123}
        /// </summary>
        /// <example>{"variableName":"Sign up now","variableName2":123}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateInput" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the published email template.
        /// </param>
        /// <param name="variables">
        /// Template variables object with key/value pairs.<br/>
        /// Example: {"variableName":"Sign up now","variableName2":123}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailTemplateInput(
            string id,
            object? variables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateInput" /> class.
        /// </summary>
        public EmailTemplateInput()
        {
        }
    }
}