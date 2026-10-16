
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListInboxesResponseSuccessDataItem
    {
        /// <summary>
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </summary>
        /// <example>b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Internal name for the inbox. Recipients do not see it.<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The address of the inbox.<br/>
        /// Example: support@acme.com
        /// </summary>
        /// <example>support@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// The name recipients see when mail is sent from this inbox. `null` when not set.<br/>
        /// Example: Ada from Support
        /// </summary>
        /// <example>Ada from Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        public string? FromName { get; set; }

        /// <summary>
        /// The number of unread threads in the Inbox folder.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unread")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unread { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of the newest received email in the Inbox folder. `null` when the folder has no received email.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </summary>
        /// <example>2026-08-05T14:03:11.229Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_received")]
        public global::System.DateTime? LastReceived { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the inbox was created.<br/>
        /// Example: 2026-08-01T09:12:44.512Z
        /// </summary>
        /// <example>2026-08-01T09:12:44.512Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the inbox was last updated.<br/>
        /// Example: 2026-08-03T10:20:05.118Z
        /// </summary>
        /// <example>2026-08-03T10:20:05.118Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInboxesResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </param>
        /// <param name="emailAddress">
        /// The address of the inbox.<br/>
        /// Example: support@acme.com
        /// </param>
        /// <param name="unread">
        /// The number of unread threads in the Inbox folder.<br/>
        /// Example: 3
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when the inbox was created.<br/>
        /// Example: 2026-08-01T09:12:44.512Z
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp when the inbox was last updated.<br/>
        /// Example: 2026-08-03T10:20:05.118Z
        /// </param>
        /// <param name="name">
        /// Internal name for the inbox. Recipients do not see it.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="fromName">
        /// The name recipients see when mail is sent from this inbox. `null` when not set.<br/>
        /// Example: Ada from Support
        /// </param>
        /// <param name="lastReceived">
        /// ISO 8601 timestamp of the newest received email in the Inbox folder. `null` when the folder has no received email.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListInboxesResponseSuccessDataItem(
            global::System.Guid id,
            string emailAddress,
            int unread,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            string? fromName,
            global::System.DateTime? lastReceived)
        {
            this.Id = id;
            this.Name = name;
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.FromName = fromName;
            this.Unread = unread;
            this.LastReceived = lastReceived;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInboxesResponseSuccessDataItem" /> class.
        /// </summary>
        public ListInboxesResponseSuccessDataItem()
        {
        }

    }
}