
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSegmentOptions
    {
        /// <summary>
        /// The name of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the segment.
        /// </param>
        /// <param name="filter">
        /// Filter conditions for the segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSegmentOptions(
            string name,
            object? filter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentOptions" /> class.
        /// </summary>
        public CreateSegmentOptions()
        {
        }
    }
}