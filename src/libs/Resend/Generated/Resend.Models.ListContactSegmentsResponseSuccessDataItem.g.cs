
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListContactSegmentsResponseSuccessDataItem
    {
        /// <summary>
        /// Unique identifier for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp indicating when the contact was added to the segment.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactSegmentsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the segment.
        /// </param>
        /// <param name="name">
        /// Name of the segment.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the contact was added to the segment.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContactSegmentsResponseSuccessDataItem(
            string? id,
            string? name,
            string? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactSegmentsResponseSuccessDataItem" /> class.
        /// </summary>
        public ListContactSegmentsResponseSuccessDataItem()
        {
        }

    }
}