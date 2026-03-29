
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSegmentResponseSuccess
    {
        /// <summary>
        /// The ID of the segment.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Example: segment
        /// </summary>
        /// <example>segment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The name of the segment.<br/>
        /// Example: Active Users
        /// </summary>
        /// <example>Active Users</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the audience this segment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Filter conditions for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public object? Filter { get; set; }

        /// <summary>
        /// Timestamp indicating when the segment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSegmentResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the segment.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: segment
        /// </param>
        /// <param name="name">
        /// The name of the segment.<br/>
        /// Example: Active Users
        /// </param>
        /// <param name="filter">
        /// Filter conditions for the segment.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the segment was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSegmentResponseSuccess(
            string? id,
            string? @object,
            string? name,
            object? filter,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Object = @object;
            this.Name = name;
            this.Filter = filter;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSegmentResponseSuccess" /> class.
        /// </summary>
        public GetSegmentResponseSuccess()
        {
        }
    }
}