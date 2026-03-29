
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrievedAttachment
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: attachment
        /// </summary>
        /// <example>attachment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the attachment.<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>660e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The filename of the attachment.<br/>
        /// Example: document.pdf
        /// </summary>
        /// <example>document.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The MIME type of the attachment.<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The content ID for inline attachments.<br/>
        /// Example: img001
        /// </summary>
        /// <example>img001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        public string? ContentId { get; set; }

        /// <summary>
        /// How the attachment should be displayed.<br/>
        /// Example: attachment
        /// </summary>
        /// <example>attachment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_disposition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.RetrievedAttachmentContentDispositionJsonConverter))]
        public global::Resend.RetrievedAttachmentContentDisposition? ContentDisposition { get; set; }

        /// <summary>
        /// Signed URL to download the attachment content.<br/>
        /// Example: https://cloudfront.example.com/path?Signature=...
        /// </summary>
        /// <example>https://cloudfront.example.com/path?Signature=...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Timestamp when the download URL expires.<br/>
        /// Example: 2024-10-27T18:30:00.000Z
        /// </summary>
        /// <example>2024-10-27T18:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Size of the attachment in bytes.<br/>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedAttachment" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: attachment
        /// </param>
        /// <param name="id">
        /// The ID of the attachment.<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.<br/>
        /// Example: document.pdf
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment.<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="contentId">
        /// The content ID for inline attachments.<br/>
        /// Example: img001
        /// </param>
        /// <param name="contentDisposition">
        /// How the attachment should be displayed.<br/>
        /// Example: attachment
        /// </param>
        /// <param name="downloadUrl">
        /// Signed URL to download the attachment content.<br/>
        /// Example: https://cloudfront.example.com/path?Signature=...
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp when the download URL expires.<br/>
        /// Example: 2024-10-27T18:30:00.000Z
        /// </param>
        /// <param name="size">
        /// Size of the attachment in bytes.<br/>
        /// Example: 2048
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievedAttachment(
            string? @object,
            global::System.Guid? id,
            string? filename,
            string? contentType,
            string? contentId,
            global::Resend.RetrievedAttachmentContentDisposition? contentDisposition,
            string? downloadUrl,
            global::System.DateTime? expiresAt,
            long? size)
        {
            this.Object = @object;
            this.Id = id;
            this.Filename = filename;
            this.ContentType = contentType;
            this.ContentId = contentId;
            this.ContentDisposition = contentDisposition;
            this.DownloadUrl = downloadUrl;
            this.ExpiresAt = expiresAt;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedAttachment" /> class.
        /// </summary>
        public RetrievedAttachment()
        {
        }
    }
}