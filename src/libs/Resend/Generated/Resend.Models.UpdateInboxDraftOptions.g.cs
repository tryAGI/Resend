
#nullable enable

namespace Resend
{
    /// <summary>
    /// Send at least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments`. Omitted fields are left unchanged. Setting `text` or `html` replaces the whole body, so the body part you omit becomes `null`. The merged draft must contain at least one non-empty field, and its combined recipients cannot exceed 50.
    /// </summary>
    public sealed partial class UpdateInboxDraftOptions
    {
        /// <summary>
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name. Pass `null` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </summary>
        /// <example>[ada@example.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? To { get; set; }

        /// <summary>
        /// The CC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Cc { get; set; }

        /// <summary>
        /// The BCC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Bcc { get; set; }

        /// <summary>
        /// The subject. Max 2000 characters. Cannot be only whitespace or contain a line break. Pass `null` to clear.<br/>
        /// Example: Refund issued for order 1041
        /// </summary>
        /// <example>Refund issued for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The HTML body. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text body. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Files to store on the draft. Each one needs a `filename` and either `content` or a `path` URL. A `path` file is downloaded when the request is made and stored on the draft. When both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft, downloaded ones included, can total at most 25 MB. A `path` that does not start with `http` or `https`, or that cannot be downloaded, returns a 422, and so does a request whose downloads take more than 20 seconds together. An empty file or a blocked file type returns a 422. Sending the field replaces every attachment on the draft. Send `[]` to remove them all. `null` also removes them all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxDraftOptions" /> class.
        /// </summary>
        /// <param name="to">
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name. Pass `null` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </param>
        /// <param name="cc">
        /// The CC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients. Pass `null` or `[]` to clear. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="subject">
        /// The subject. Max 2000 characters. Cannot be only whitespace or contain a line break. Pass `null` to clear.<br/>
        /// Example: Refund issued for order 1041
        /// </param>
        /// <param name="html">
        /// The HTML body. Pass `null` to clear.
        /// </param>
        /// <param name="text">
        /// The plain text body. Pass `null` to clear.
        /// </param>
        /// <param name="attachments">
        /// Files to store on the draft. Each one needs a `filename` and either `content` or a `path` URL. A `path` file is downloaded when the request is made and stored on the draft. When both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft, downloaded ones included, can total at most 25 MB. A `path` that does not start with `http` or `https`, or that cannot be downloaded, returns a 422, and so does a request whose downloads take more than 20 seconds together. An empty file or a blocked file type returns a 422. Sending the field replaces every attachment on the draft. Send `[]` to remove them all. `null` also removes them all.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxDraftOptions(
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? to,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc,
            string? subject,
            string? html,
            string? text,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? attachments)
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Subject = subject;
            this.Html = html;
            this.Text = text;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxDraftOptions" /> class.
        /// </summary>
        public UpdateInboxDraftOptions()
        {
        }

    }
}