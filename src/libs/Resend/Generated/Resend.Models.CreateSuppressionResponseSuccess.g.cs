
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSuppressionResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: suppression
        /// </summary>
        /// <example>suppression</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the created suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSuppressionResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: suppression
        /// </param>
        /// <param name="id">
        /// Unique identifier for the created suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSuppressionResponseSuccess(
            string? @object,
            string? id)
        {
            this.Object = @object;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSuppressionResponseSuccess" /> class.
        /// </summary>
        public CreateSuppressionResponseSuccess()
        {
        }

    }
}