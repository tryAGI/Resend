
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Attachment
    {
        /// <summary>
        /// Content of an attached file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public byte[]? Content { get; set; }

        /// <summary>
        /// Content of an attached file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentname")]
        public string? Contentname { get; set; }

        /// <summary>
        /// Name of attached file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Path where the attachment file is hosted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Optional content type for the attachment, if not set it will be derived from the filename property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Content ID for embedding inline images using cid references (e.g., cid:image001).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        public string? ContentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="content">
        /// Content of an attached file.
        /// </param>
        /// <param name="contentname">
        /// Content of an attached file.
        /// </param>
        /// <param name="filename">
        /// Name of attached file.
        /// </param>
        /// <param name="path">
        /// Path where the attachment file is hosted
        /// </param>
        /// <param name="contentType">
        /// Optional content type for the attachment, if not set it will be derived from the filename property
        /// </param>
        /// <param name="contentId">
        /// Content ID for embedding inline images using cid references (e.g., cid:image001).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Attachment(
            byte[]? content,
            string? contentname,
            string? filename,
            string? path,
            string? contentType,
            string? contentId)
        {
            this.Content = content;
            this.Contentname = contentname;
            this.Filename = filename;
            this.Path = path;
            this.ContentType = contentType;
            this.ContentId = contentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        public Attachment()
        {
        }
    }
}