
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactEventData
    {
        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier for the audience this contact belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Array of segment IDs the contact belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_ids")]
        public global::System.Collections.Generic.IList<string>? SegmentIds { get; set; }

        /// <summary>
        /// Timestamp when the contact was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the contact was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Contact's email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Contact's first name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Contact's last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Whether the contact has unsubscribed from all emails sent from your team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsubscribed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Unsubscribed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the contact.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the contact was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the contact was last updated.
        /// </param>
        /// <param name="email">
        /// Contact's email address.
        /// </param>
        /// <param name="unsubscribed">
        /// Whether the contact has unsubscribed from all emails sent from your team.
        /// </param>
        /// <param name="audienceId">
        /// Unique identifier for the audience this contact belongs to.
        /// </param>
        /// <param name="segmentIds">
        /// Array of segment IDs the contact belongs to.
        /// </param>
        /// <param name="firstName">
        /// Contact's first name.
        /// </param>
        /// <param name="lastName">
        /// Contact's last name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactEventData(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string email,
            bool unsubscribed,
            string? audienceId,
            global::System.Collections.Generic.IList<string>? segmentIds,
            string? firstName,
            string? lastName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AudienceId = audienceId;
            this.SegmentIds = segmentIds;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Unsubscribed = unsubscribed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactEventData" /> class.
        /// </summary>
        public ContactEventData()
        {
        }

    }
}