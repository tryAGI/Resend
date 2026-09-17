
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SuppressionEventData
    {
        /// <summary>
        /// Unique identifier for the suppression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address that is suppressed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Origin of the suppression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.SuppressionEventDataOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.SuppressionEventDataOrigin Origin { get; set; }

        /// <summary>
        /// Identifier of the event that caused the suppression, such as the email that bounced or complained. Null for manually added suppressions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// Timestamp when the suppression was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressionEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the suppression.
        /// </param>
        /// <param name="email">
        /// Email address that is suppressed.
        /// </param>
        /// <param name="origin">
        /// Origin of the suppression.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the suppression was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="sourceId">
        /// Identifier of the event that caused the suppression, such as the email that bounced or complained. Null for manually added suppressions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuppressionEventData(
            string id,
            string email,
            global::Resend.SuppressionEventDataOrigin origin,
            global::System.DateTime createdAt,
            string? sourceId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Origin = origin;
            this.SourceId = sourceId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressionEventData" /> class.
        /// </summary>
        public SuppressionEventData()
        {
        }

    }
}