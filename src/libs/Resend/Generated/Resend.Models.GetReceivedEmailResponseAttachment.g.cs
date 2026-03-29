
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReceivedEmailResponseAttachment
    {
        /// <summary>
        /// The ID of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

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
        /// The content ID for inline attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        public string? ContentId { get; set; }

        /// <summary>
        /// How the attachment should be displayed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_disposition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetReceivedEmailResponseAttachmentContentDispositionJsonConverter))]
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? ContentDisposition { get; set; }

        /// <summary>
        /// Size of the attachment in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReceivedEmailResponseAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the attachment.
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment.
        /// </param>
        /// <param name="contentId">
        /// The content ID for inline attachments.
        /// </param>
        /// <param name="contentDisposition">
        /// How the attachment should be displayed.
        /// </param>
        /// <param name="size">
        /// Size of the attachment in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReceivedEmailResponseAttachment(
            global::System.Guid? id,
            string? filename,
            string? contentType,
            string? contentId,
            global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? contentDisposition,
            long? size)
        {
            this.Id = id;
            this.Filename = filename;
            this.ContentType = contentType;
            this.ContentId = contentId;
            this.ContentDisposition = contentDisposition;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReceivedEmailResponseAttachment" /> class.
        /// </summary>
        public GetReceivedEmailResponseAttachment()
        {
        }
    }
}