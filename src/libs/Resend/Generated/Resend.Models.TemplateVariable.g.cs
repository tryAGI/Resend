
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateVariable
    {
        /// <summary>
        /// The ID of the template variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.TemplateVariableTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.TemplateVariableType Type { get; set; }

        /// <summary>
        /// The fallback value of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>))]
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? FallbackValue { get; set; }

        /// <summary>
        /// Timestamp indicating when the variable was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the variable was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the variable.
        /// </param>
        /// <param name="type">
        /// The type of the variable.
        /// </param>
        /// <param name="id">
        /// The ID of the template variable.
        /// </param>
        /// <param name="fallbackValue">
        /// The fallback value of the variable.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the variable was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp indicating when the variable was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateVariable(
            string key,
            global::Resend.TemplateVariableType type,
            string? id,
            global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? fallbackValue,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.FallbackValue = fallbackValue;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariable" /> class.
        /// </summary>
        public TemplateVariable()
        {
        }
    }
}