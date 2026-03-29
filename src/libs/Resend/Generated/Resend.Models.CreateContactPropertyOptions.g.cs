
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContactPropertyOptions
    {
        /// <summary>
        /// The property key. Max length is 50 characters. Only alphanumeric characters and underscores are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The property type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateContactPropertyOptionsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.CreateContactPropertyOptionsType Type { get; set; }

        /// <summary>
        /// The default value to use when the property is not set for a contact. Must match the type specified in the type field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Resend.OneOf<string, double?>? FallbackValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyOptions" /> class.
        /// </summary>
        /// <param name="key">
        /// The property key. Max length is 50 characters. Only alphanumeric characters and underscores are allowed.
        /// </param>
        /// <param name="type">
        /// The property type.
        /// </param>
        /// <param name="fallbackValue">
        /// The default value to use when the property is not set for a contact. Must match the type specified in the type field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactPropertyOptions(
            string key,
            global::Resend.CreateContactPropertyOptionsType type,
            global::Resend.OneOf<string, double?>? fallbackValue)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.FallbackValue = fallbackValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactPropertyOptions" /> class.
        /// </summary>
        public CreateContactPropertyOptions()
        {
        }
    }
}