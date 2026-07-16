
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRemoveSuppressionsResponseSuccessDataItem
    {
        /// <summary>
        /// Type of the object.<br/>
        /// Example: suppression
        /// </summary>
        /// <example>suppression</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates whether the suppression was successfully deleted.<br/>
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
        /// Initializes a new instance of the <see cref="BatchRemoveSuppressionsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the object.<br/>
        /// Example: suppression
        /// </param>
        /// <param name="id">
        /// Unique identifier for the suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the suppression was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRemoveSuppressionsResponseSuccessDataItem(
            string? @object,
            string? id,
            bool? deleted)
        {
            this.Object = @object;
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRemoveSuppressionsResponseSuccessDataItem" /> class.
        /// </summary>
        public BatchRemoveSuppressionsResponseSuccessDataItem()
        {
        }

    }
}