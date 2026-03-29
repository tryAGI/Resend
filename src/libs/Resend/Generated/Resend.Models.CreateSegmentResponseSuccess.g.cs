
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSegmentResponseSuccess
    {
        /// <summary>
        /// The ID of the segment.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type of the response.<br/>
        /// Example: segment
        /// </summary>
        /// <example>segment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the segment.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object type of the response.<br/>
        /// Example: segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSegmentResponseSuccess(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentResponseSuccess" /> class.
        /// </summary>
        public CreateSegmentResponseSuccess()
        {
        }
    }
}