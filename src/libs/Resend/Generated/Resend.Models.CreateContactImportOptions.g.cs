
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContactImportOptions
    {
        /// <summary>
        /// CSV file to import. Maximum size is 50MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// CSV file to import. Maximum size is 50MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// JSON-encoded object mapping contact fields and custom property keys to CSV column names. Supports `email`, `first_name`, `last_name`, `unsubscribed`, and `properties`. Custom property mappings can include `type` as `string`, `number`, or `boolean`; defaults to `string`.<br/>
        /// Example: {"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}
        /// </summary>
        /// <example>{"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_map")]
        public string? ColumnMap { get; set; }

        /// <summary>
        /// Strategy to use when an imported contact already exists.<br/>
        /// Default Value: skip<br/>
        /// Example: skip
        /// </summary>
        /// <example>skip</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_conflict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateContactImportOptionsOnConflictJsonConverter))]
        public global::Resend.CreateContactImportOptionsOnConflict? OnConflict { get; set; }

        /// <summary>
        /// Strategy to use when an imported row fails validation.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </summary>
        /// <example>continue</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateContactImportOptionsOnErrorJsonConverter))]
        public global::Resend.CreateContactImportOptionsOnError? OnError { get; set; }

        /// <summary>
        /// JSON-encoded array of segments to add imported contacts to.<br/>
        /// Example: [{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]
        /// </summary>
        /// <example>[{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public string? Segments { get; set; }

        /// <summary>
        /// JSON-encoded array of topic subscriptions to apply to imported contacts. Each `subscription` must be `opt_in` or `opt_out`.<br/>
        /// Example: [{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]
        /// </summary>
        /// <example>[{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public string? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactImportOptions" /> class.
        /// </summary>
        /// <param name="file">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="filename">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="columnMap">
        /// JSON-encoded object mapping contact fields and custom property keys to CSV column names. Supports `email`, `first_name`, `last_name`, `unsubscribed`, and `properties`. Custom property mappings can include `type` as `string`, `number`, or `boolean`; defaults to `string`.<br/>
        /// Example: {"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}
        /// </param>
        /// <param name="onConflict">
        /// Strategy to use when an imported contact already exists.<br/>
        /// Default Value: skip<br/>
        /// Example: skip
        /// </param>
        /// <param name="onError">
        /// Strategy to use when an imported row fails validation.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </param>
        /// <param name="segments">
        /// JSON-encoded array of segments to add imported contacts to.<br/>
        /// Example: [{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]
        /// </param>
        /// <param name="topics">
        /// JSON-encoded array of topic subscriptions to apply to imported contacts. Each `subscription` must be `opt_in` or `opt_out`.<br/>
        /// Example: [{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactImportOptions(
            byte[] file,
            string filename,
            string? columnMap,
            global::Resend.CreateContactImportOptionsOnConflict? onConflict,
            global::Resend.CreateContactImportOptionsOnError? onError,
            string? segments,
            string? topics)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ColumnMap = columnMap;
            this.OnConflict = onConflict;
            this.OnError = onError;
            this.Segments = segments;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactImportOptions" /> class.
        /// </summary>
        public CreateContactImportOptions()
        {
        }

    }
}