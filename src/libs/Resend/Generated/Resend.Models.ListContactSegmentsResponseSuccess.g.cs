
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListContactSegmentsResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Indicates if there are more results available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Array containing segment information for this contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactSegmentsResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: list
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results available.
        /// </param>
        /// <param name="data">
        /// Array containing segment information for this contact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContactSegmentsResponseSuccess(
            string? @object,
            bool? hasMore,
            global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? data)
        {
            this.Object = @object;
            this.HasMore = hasMore;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactSegmentsResponseSuccess" /> class.
        /// </summary>
        public ListContactSegmentsResponseSuccess()
        {
        }
    }
}