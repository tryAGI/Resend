
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSuppressionsResponseSuccessDataItem
    {
        /// <summary>
        /// Unique identifier for the suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Email address that is suppressed.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </summary>
        /// <example>steve.wozniak@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Origin of the suppression.<br/>
        /// Example: manual
        /// </summary>
        /// <example>manual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ListSuppressionsResponseSuccessDataItemOriginJsonConverter))]
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Origin { get; set; }

        /// <summary>
        /// Identifier of the event that caused the suppression, such as the email that bounced or complained.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// Timestamp indicating when the suppression was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSuppressionsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the suppression.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
        /// <param name="email">
        /// Email address that is suppressed.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </param>
        /// <param name="origin">
        /// Origin of the suppression.<br/>
        /// Example: manual
        /// </param>
        /// <param name="sourceId">
        /// Identifier of the event that caused the suppression, such as the email that bounced or complained.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the suppression was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSuppressionsResponseSuccessDataItem(
            string? id,
            string? email,
            global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? origin,
            string? sourceId,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Email = email;
            this.Origin = origin;
            this.SourceId = sourceId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSuppressionsResponseSuccessDataItem" /> class.
        /// </summary>
        public ListSuppressionsResponseSuccessDataItem()
        {
        }

    }
}