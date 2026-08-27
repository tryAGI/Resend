
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListSegmentsResponseSuccessDataItem
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
        /// The ID of the audience this segment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Timestamp indicating when the segment was created.<br/>
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
        /// Initializes a new instance of the <see cref="ListSegmentsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the segment.
        /// </param>
        /// <param name="name">
        /// Name of the segment.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the segment was created.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSegmentsResponseSuccessDataItem(
            string? id,
            string? name,
            string? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsResponseSuccessDataItem" /> class.
        /// </summary>
        public ListSegmentsResponseSuccessDataItem()
        {
        }

    }
}