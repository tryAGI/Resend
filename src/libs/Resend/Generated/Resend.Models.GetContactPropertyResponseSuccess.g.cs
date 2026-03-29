
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContactPropertyResponseSuccess
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: contact_property
        /// </summary>
        /// <example>contact_property</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the contact property.<br/>
        /// Example: b6d24b8e-af0b-4c3c-be0c-359bbd97381e
        /// </summary>
        /// <example>b6d24b8e-af0b-4c3c-be0c-359bbd97381e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The property key.<br/>
        /// Example: company_name
        /// </summary>
        /// <example>company_name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The property type.<br/>
        /// Example: string
        /// </summary>
        /// <example>string</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The default value when the property is not set for a contact.<br/>
        /// Example: Acme Corp
        /// </summary>
        /// <example>Acme Corp</example>
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
        /// Initializes a new instance of the <see cref="GetContactPropertyResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: contact_property
        /// </param>
        /// <param name="id">
        /// The ID of the contact property.<br/>
        /// Example: b6d24b8e-af0b-4c3c-be0c-359bbd97381e
        /// </param>
        /// <param name="key">
        /// The property key.<br/>
        /// Example: company_name
        /// </param>
        /// <param name="type">
        /// The property type.<br/>
        /// Example: string
        /// </param>
        /// <param name="fallbackValue">
        /// The default value when the property is not set for a contact.<br/>
        /// Example: Acme Corp
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the contact property was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContactPropertyResponseSuccess(
            string? @object,
            string? id,
            string? key,
            string? type,
            global::Resend.OneOf<string, double?>? fallbackValue,
            global::System.DateTime? createdAt)
        {
            this.Object = @object;
            this.Id = id;
            this.Key = key;
            this.Type = type;
            this.FallbackValue = fallbackValue;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactPropertyResponseSuccess" /> class.
        /// </summary>
        public GetContactPropertyResponseSuccess()
        {
        }
    }
}