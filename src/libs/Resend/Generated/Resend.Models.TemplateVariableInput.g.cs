
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateVariableInput
    {
        /// <summary>
        /// The key of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The type of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.TemplateVariableInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.TemplateVariableInputType Type { get; set; }

        /// <summary>
        /// The fallback value of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>))]
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? FallbackValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariableInput" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the variable.
        /// </param>
        /// <param name="type">
        /// The type of the variable.
        /// </param>
        /// <param name="fallbackValue">
        /// The fallback value of the variable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateVariableInput(
            string key,
            global::Resend.TemplateVariableInputType type,
            global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? fallbackValue)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.FallbackValue = fallbackValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariableInput" /> class.
        /// </summary>
        public TemplateVariableInput()
        {
        }
    }
}