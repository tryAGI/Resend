
#nullable enable

namespace Resend
{
    /// <summary>
    /// A file stored on a draft.
    /// </summary>
    public sealed partial class InboxDraftAttachment
    {
        /// <summary>
        /// The ID of the attachment.<br/>
        /// Example: 5c1e9d2a-7b3f-4e8a-9c6d-2f0a1b3c4d5e
        /// </summary>
        /// <example>5c1e9d2a-7b3f-4e8a-9c6d-2f0a1b3c4d5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The filename of the attachment.<br/>
        /// Example: receipt.pdf
        /// </summary>
        /// <example>receipt.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The MIME type of the attachment.<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The size of the attachment in bytes.<br/>
        /// Example: 20841
        /// </summary>
        /// <example>20841</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the attachment.<br/>
        /// Example: 5c1e9d2a-7b3f-4e8a-9c6d-2f0a1b3c4d5e
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.<br/>
        /// Example: receipt.pdf
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment.<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="size">
        /// The size of the attachment in bytes.<br/>
        /// Example: 20841
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxDraftAttachment(
            global::System.Guid id,
            string filename,
            string contentType,
            long size)
        {
            this.Id = id;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDraftAttachment" /> class.
        /// </summary>
        public InboxDraftAttachment()
        {
        }

    }
}