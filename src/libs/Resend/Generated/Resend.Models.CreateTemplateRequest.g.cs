
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTemplateRequest
    {
        /// <summary>
        /// The name of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// The plain text version of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the template.
        /// </param>
        /// <param name="html">
        /// The HTML version of the template.
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
        /// <param name="text">
        /// The plain text version of the template.
        /// </param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTemplateRequest(
            string name,
            string html,
            string? alias,
            string? from,
            string? subject,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? text,
            global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? variables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Alias = alias;
            this.From = from;
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Text = text;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateRequest" /> class.
        /// </summary>
        public CreateTemplateRequest()
        {
        }
    }
}