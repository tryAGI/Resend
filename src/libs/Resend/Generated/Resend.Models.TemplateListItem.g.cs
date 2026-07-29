
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateListItem
    {
        /// <summary>
        /// The ID of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The publication status of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.TemplateListItemStatusJsonConverter))]
        public global::Resend.TemplateListItemStatus? Status { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was published.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public string? PublishedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was created.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was last updated.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The alias of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the template.
        /// </param>
        /// <param name="name">
        /// The name of the template.
        /// </param>
        /// <param name="status">
        /// The publication status of the template.
        /// </param>
        /// <param name="publishedAt">
        /// Timestamp indicating when the template was published.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the template was created.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp indicating when the template was last updated.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
        /// <param name="alias">
        /// The alias of the template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListItem(
            string? id,
            string? name,
            global::Resend.TemplateListItemStatus? status,
            string? publishedAt,
            string? createdAt,
            string? updatedAt,
            string? alias)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.PublishedAt = publishedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListItem" /> class.
        /// </summary>
        public TemplateListItem()
        {
        }

    }
}