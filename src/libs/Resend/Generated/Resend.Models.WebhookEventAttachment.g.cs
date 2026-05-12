
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEventAttachment
    {
        /// <summary>
        /// Unique identifier for the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The filename of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The MIME type of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The content disposition (e.g., `inline` or `attachment`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_disposition")]
        public string? ContentDisposition { get; set; }

        /// <summary>
        /// Content-ID header used for referencing inline images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        public string? ContentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the attachment.
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment.
        /// </param>
        /// <param name="contentDisposition">
        /// The content disposition (e.g., `inline` or `attachment`).
        /// </param>
        /// <param name="contentId">
        /// Content-ID header used for referencing inline images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventAttachment(
            string id,
            string? filename,
            string? contentType,
            string? contentDisposition,
            string? contentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.ContentType = contentType;
            this.ContentDisposition = contentDisposition;
            this.ContentId = contentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventAttachment" /> class.
        /// </summary>
        public WebhookEventAttachment()
        {
        }

    }
}