
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateInboxLabelOptions
    {
        /// <summary>
        /// A new name for the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Billing
        /// </summary>
        /// <example>Billing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new color for the label, as a `#RRGGBB` hex color. It is stored in uppercase.<br/>
        /// Example: #F76B15
        /// </summary>
        /// <example>#F76B15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxLabelOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Billing
        /// </param>
        /// <param name="color">
        /// A new color for the label, as a `#RRGGBB` hex color. It is stored in uppercase.<br/>
        /// Example: #F76B15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxLabelOptions(
            string? name,
            string? color)
        {
            this.Name = name;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxLabelOptions" /> class.
        /// </summary>
        public UpdateInboxLabelOptions()
        {
        }

    }
}