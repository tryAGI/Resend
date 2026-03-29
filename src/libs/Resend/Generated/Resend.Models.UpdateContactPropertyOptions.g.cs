
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactPropertyOptions
    {
        /// <summary>
        /// The default value to use when the property is not set for a contact. Must match the type of the property.
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
        /// Initializes a new instance of the <see cref="UpdateContactPropertyOptions" /> class.
        /// </summary>
        /// <param name="fallbackValue">
        /// The default value to use when the property is not set for a contact. Must match the type of the property.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactPropertyOptions(
            global::Resend.OneOf<string, double?>? fallbackValue)
        {
            this.FallbackValue = fallbackValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactPropertyOptions" /> class.
        /// </summary>
        public UpdateContactPropertyOptions()
        {
        }
    }
}