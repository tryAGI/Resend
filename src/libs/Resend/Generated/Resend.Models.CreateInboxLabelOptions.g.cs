
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateInboxLabelOptions
    {
        /// <summary>
        /// The name of the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Urgent
        /// </summary>
        /// <example>Urgent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The color of the label, as a `#RRGGBB` hex color. It is stored in uppercase. When omitted, a random color from the dashboard palette is used.<br/>
        /// Example: #E93D82
        /// </summary>
        /// <example>#E93D82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxLabelOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Urgent
        /// </param>
        /// <param name="color">
        /// The color of the label, as a `#RRGGBB` hex color. It is stored in uppercase. When omitted, a random color from the dashboard palette is used.<br/>
        /// Example: #E93D82
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInboxLabelOptions(
            string name,
            string? color)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxLabelOptions" /> class.
        /// </summary>
        public CreateInboxLabelOptions()
        {
        }

    }
}