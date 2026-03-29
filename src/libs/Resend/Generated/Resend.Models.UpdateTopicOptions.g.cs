
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTopicOptions
    {
        /// <summary>
        /// The name of the topic. Max 50 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the topic. Max 200 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The visibility of the topic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateTopicOptionsVisibilityJsonConverter))]
        public global::Resend.UpdateTopicOptionsVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. Max 50 characters.
        /// </param>
        /// <param name="description">
        /// A description of the topic. Max 200 characters.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the topic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTopicOptions(
            string? name,
            string? description,
            global::Resend.UpdateTopicOptionsVisibility? visibility)
        {
            this.Name = name;
            this.Description = description;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicOptions" /> class.
        /// </summary>
        public UpdateTopicOptions()
        {
        }
    }
}