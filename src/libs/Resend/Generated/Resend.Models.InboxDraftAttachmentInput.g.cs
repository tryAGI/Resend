
#nullable enable

namespace Resend
{
    /// <summary>
    /// A file to store on a draft. Unlike `POST /emails` attachments, a draft attachment cannot use `path` or `content_id`. A `path` without `content` returns a 422, and when both are sent, `path` is ignored.
    /// </summary>
    public sealed partial class InboxDraftAttachmentInput
    {
        /// <summary>
        /// The content of the file, encoded in base64. It cannot be empty.<br/>
        /// Example: aGVsbG8gZTJl
        /// </summary>
        /// <example>aGVsbG8gZTJl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The filename of the attachment. A blocked file type returns a 422.<br/>
        /// Example: receipt.pdf
        /// </summary>
        /// <example>receipt.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The MIME type of the attachment. It must be a valid MIME type, such as `application/pdf`, or the request returns a 422.<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachmentInput" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the file, encoded in base64. It cannot be empty.<br/>
        /// Example: aGVsbG8gZTJl
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment. A blocked file type returns a 422.<br/>
        /// Example: receipt.pdf
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment. It must be a valid MIME type, such as `application/pdf`, or the request returns a 422.<br/>
        /// Example: application/pdf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraftAttachmentInput(
            string content,
            string filename,
            string contentType)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachmentInput" /> class.
        /// </summary>
        public InboxDraftAttachmentInput()
        {
        }

    }
}