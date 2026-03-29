
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Template2
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: template
        /// </summary>
        /// <example>template</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the current version of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_version_id")]
        public string? CurrentVersionId { get; set; }

        /// <summary>
        /// The name of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The alias of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Reply-to email addresses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// The HTML version of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text version of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Variables { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The publication status of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.TemplateStatusJsonConverter))]
        public global::Resend.TemplateStatus? Status { get; set; }

        /// <summary>
        /// Timestamp indicating when the template was published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Indicates whether the template has unpublished versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unpublished_versions")]
        public bool? HasUnpublishedVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template2" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: template
        /// </param>
        /// <param name="id">
        /// The ID of the template.
        /// </param>
        /// <param name="currentVersionId">
        /// The ID of the current version of the template.
        /// </param>
        /// <param name="name">
        /// The name of the template.
        /// </param>
        /// <param name="alias">
        /// The alias of the template.
        /// </param>
        /// <param name="from">
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </param>
        /// <param name="subject">
        /// Email subject.
        /// </param>
        /// <param name="replyTo">
        /// Reply-to email addresses.
        /// </param>
        /// <param name="html">
        /// The HTML version of the template.
        /// </param>
        /// <param name="text">
        /// The plain text version of the template.
        /// </param>
        /// <param name="variables"></param>
        /// <param name="createdAt">
        /// Timestamp indicating when the template was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp indicating when the template was last updated.
        /// </param>
        /// <param name="status">
        /// The publication status of the template.
        /// </param>
        /// <param name="publishedAt">
        /// Timestamp indicating when the template was published.
        /// </param>
        /// <param name="hasUnpublishedVersions">
        /// Indicates whether the template has unpublished versions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Template2(
            string? @object,
            string? id,
            string? currentVersionId,
            string? name,
            string? alias,
            string? from,
            string? subject,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? html,
            string? text,
            global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? variables,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Resend.TemplateStatus? status,
            global::System.DateTime? publishedAt,
            bool? hasUnpublishedVersions)
        {
            this.Object = @object;
            this.Id = id;
            this.CurrentVersionId = currentVersionId;
            this.Name = name;
            this.Alias = alias;
            this.From = from;
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.Html = html;
            this.Text = text;
            this.Variables = variables;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status;
            this.PublishedAt = publishedAt;
            this.HasUnpublishedVersions = hasUnpublishedVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template2" /> class.
        /// </summary>
        public Template2()
        {
        }
    }
}