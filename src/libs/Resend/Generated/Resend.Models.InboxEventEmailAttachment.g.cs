
#nullable enable

namespace Resend
{
    /// <summary>
    /// An attachment on an email in an inbox webhook event.
    /// </summary>
    public sealed partial class InboxEventEmailAttachment
    {
        /// <summary>
        /// The ID of the attachment.<br/>
        /// Example: 2a0c9ce0-3112-4728-976e-47ddcd16a318
        /// </summary>
        /// <example>2a0c9ce0-3112-4728-976e-47ddcd16a318</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The filename of the attachment.<br/>
        /// Example: invoice.pdf
        /// </summary>
        /// <example>invoice.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The size of the attachment in bytes.<br/>
        /// Example: 48213
        /// </summary>
        /// <example>48213</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventEmailAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the attachment.<br/>
        /// Example: 2a0c9ce0-3112-4728-976e-47ddcd16a318
        /// </param>
        /// <param name="filename">
        /// The filename of the attachment.<br/>
        /// Example: invoice.pdf
        /// </param>
        /// <param name="size">
        /// The size of the attachment in bytes.<br/>
        /// Example: 48213
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxEventEmailAttachment(
            string id,
            string? filename,
            long? size)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxEventEmailAttachment" /> class.
        /// </summary>
        public InboxEventEmailAttachment()
        {
        }

    }
}