
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddContactToSegmentResponseSuccess
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: contact_segment
        /// </summary>
        /// <example>contact_segment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public string? ContactId { get; set; }

        /// <summary>
        /// The ID of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_id")]
        public string? SegmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddContactToSegmentResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: contact_segment
        /// </param>
        /// <param name="contactId">
        /// The ID of the contact.
        /// </param>
        /// <param name="segmentId">
        /// The ID of the segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddContactToSegmentResponseSuccess(
            string? @object,
            string? contactId,
            string? segmentId)
        {
            this.Object = @object;
            this.ContactId = contactId;
            this.SegmentId = segmentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddContactToSegmentResponseSuccess" /> class.
        /// </summary>
        public AddContactToSegmentResponseSuccess()
        {
        }
    }
}