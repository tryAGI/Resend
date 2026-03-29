
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListContactPropertiesResponseSuccessDataItem
    {
        /// <summary>
        /// Unique identifier for the contact property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The property key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The property type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The default value when the property is not set for a contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Resend.OneOf<string, double?>? FallbackValue { get; set; }

        /// <summary>
        /// Timestamp indicating when the contact property was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactPropertiesResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the contact property.
        /// </param>
        /// <param name="key">
        /// The property key.
        /// </param>
        /// <param name="type">
        /// The property type.
        /// </param>
        /// <param name="fallbackValue">
        /// The default value when the property is not set for a contact.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the contact property was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContactPropertiesResponseSuccessDataItem(
            string? id,
            string? key,
            string? type,
            global::Resend.OneOf<string, double?>? fallbackValue,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Key = key;
            this.Type = type;
            this.FallbackValue = fallbackValue;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactPropertiesResponseSuccessDataItem" /> class.
        /// </summary>
        public ListContactPropertiesResponseSuccessDataItem()
        {
        }
    }
}