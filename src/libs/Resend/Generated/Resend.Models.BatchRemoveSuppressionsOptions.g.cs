
#nullable enable

namespace Resend
{
    /// <summary>
    /// Provide either `emails` or `ids`, but not both.
    /// </summary>
    public sealed partial class BatchRemoveSuppressionsOptions
    {
        /// <summary>
        /// Email addresses to remove from the suppression list.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </summary>
        /// <example>[steve.wozniak@gmail.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Suppression IDs to remove from the suppression list.<br/>
        /// Example: [e169aa45-1ecf-4183-9955-b1499d5701d3]
        /// </summary>
        /// <example>[e169aa45-1ecf-4183-9955-b1499d5701d3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRemoveSuppressionsOptions" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to remove from the suppression list.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </param>
        /// <param name="ids">
        /// Suppression IDs to remove from the suppression list.<br/>
        /// Example: [e169aa45-1ecf-4183-9955-b1499d5701d3]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRemoveSuppressionsOptions(
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.Emails = emails;
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRemoveSuppressionsOptions" /> class.
        /// </summary>
        public BatchRemoveSuppressionsOptions()
        {
        }

    }
}