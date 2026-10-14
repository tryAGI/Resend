
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxThreadEmailAttachment
    {
        /// <summary>
        /// The ID of the attachment.<br/>
        /// Example: 9d4f2b81-6c3a-4e7d-8b12-0a5c6d7e8f90
        /// </summary>
        /// <example>9d4f2b81-6c3a-4e7d-8b12-0a5c6d7e8f90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The filename of the attachment.<br/>
        /// Example: receipt.pdf
        /// </summary>
        /// <example>receipt.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The size of the attachment in bytes.<br/>
        /// Example: 20841
        /// </summary>
        /// <example>20841</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmailAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the attachment.<br/>
        /// Example: 9d4f2b81-6c3a-4e7d-8b12-0a5c6d7e8f90
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.<br/>
        /// Example: receipt.pdf
        /// </param>
        /// <param name="size">
        /// The size of the attachment in bytes.<br/>
        /// Example: 20841
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadEmailAttachment(
            string id,
            string? filename,
            long? size)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadEmailAttachment" /> class.
        /// </summary>
        public InboxThreadEmailAttachment()
        {
        }

    }
}