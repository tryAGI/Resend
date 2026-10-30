
#nullable enable

namespace Resend
{
    /// <summary>
    /// A file to store on a draft. Send either `content` or a `path` URL. Unlike `POST /emails` attachments, a `path` file is downloaded when the request is made, not when the draft is sent, and a draft attachment cannot use `content_id`. When both `content` and `path` are sent, `path` is ignored.
    /// </summary>
    public sealed partial class InboxDraftAttachmentInput
    {
        /// <summary>
        /// The content of the file, encoded in base64. It cannot be empty. Required without `path`.<br/>
        /// Example: aGVsbG8gZTJl
        /// </summary>
        /// <example>aGVsbG8gZTJl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// A URL to download the file from, starting with `http` or `https`. Required without `content`. A file that cannot be downloaded returns a 422, and so does a request whose downloads take more than 20 seconds together.<br/>
        /// Example: https://example.com/invoice.pdf
        /// </summary>
        /// <example>https://example.com/invoice.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The filename of the attachment. A blocked file type returns a 422.<br/>
        /// Example: receipt.pdf
        /// </summary>
        /// <example>receipt.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The MIME type of the attachment. It must be a valid MIME type, such as `application/pdf`, or the request returns a 422. Required with `content`. With `path`, it defaults to the content type of the downloaded file.<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachmentInput" /> class.
        /// </summary>
        /// <param name="filename">
        /// The filename of the attachment. A blocked file type returns a 422.<br/>
        /// Example: receipt.pdf
        /// </param>
        /// <param name="content">
        /// The content of the file, encoded in base64. It cannot be empty. Required without `path`.<br/>
        /// Example: aGVsbG8gZTJl
        /// </param>
        /// <param name="path">
        /// A URL to download the file from, starting with `http` or `https`. Required without `content`. A file that cannot be downloaded returns a 422, and so does a request whose downloads take more than 20 seconds together.<br/>
        /// Example: https://example.com/invoice.pdf
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment. It must be a valid MIME type, such as `application/pdf`, or the request returns a 422. Required with `content`. With `path`, it defaults to the content type of the downloaded file.<br/>
        /// Example: application/pdf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraftAttachmentInput(
            string filename,
            string? content,
            string? path,
            string? contentType)
        {
            this.Content = content;
            this.Path = path;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachmentInput" /> class.
        /// </summary>
        public InboxDraftAttachmentInput()
        {
        }

    }
}