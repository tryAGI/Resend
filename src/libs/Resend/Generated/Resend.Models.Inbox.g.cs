
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Inbox
    {
        /// <summary>
        /// The object type. Always `inbox`.<br/>
        /// Example: inbox
        /// </summary>
        /// <example>inbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </summary>
        /// <example>b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Internal name for the inbox. Recipients do not see it. Falls back to the inbox email address.<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The address of the inbox.<br/>
        /// Example: support@acme.com
        /// </summary>
        /// <example>support@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// The ID of the domain that owns the address.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DomainId { get; set; }

        /// <summary>
        /// The address to forward mail to when forwarding is enabled. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiving_address")]
        public string? ReceivingAddress { get; set; }

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
        /// The number of unsent drafts.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drafts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Drafts { get; set; }

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
        /// Initializes a new instance of the <see cref="Inbox" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type. Always `inbox`.<br/>
        /// Example: inbox
        /// </param>
        /// <param name="id">
        /// The ID of the inbox.<br/>
        /// Example: b3e2b2b6-3f0e-4c8e-9ad3-2f43a1e2c7f1
        /// </param>
        /// <param name="name">
        /// Internal name for the inbox. Recipients do not see it. Falls back to the inbox email address.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="emailAddress">
        /// The address of the inbox.<br/>
        /// Example: support@acme.com
        /// </param>
        /// <param name="domainId">
        /// The ID of the domain that owns the address.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="unread">
        /// The number of unread threads in the Inbox folder.<br/>
        /// Example: 3
        /// </param>
        /// <param name="drafts">
        /// The number of unsent drafts.<br/>
        /// Example: 2
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when the inbox was created.<br/>
        /// Example: 2026-08-01T09:12:44.512Z
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp when the inbox was last updated.<br/>
        /// Example: 2026-08-03T10:20:05.118Z
        /// </param>
        /// <param name="receivingAddress">
        /// The address to forward mail to when forwarding is enabled. `null` otherwise.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        public Inbox(
            string @object,
            global::System.Guid id,
            string name,
            string emailAddress,
            global::System.Guid domainId,
            int unread,
            int drafts,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? receivingAddress,
            string? fromName,
            global::System.DateTime? lastReceived)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.DomainId = domainId;
            this.ReceivingAddress = receivingAddress;
            this.FromName = fromName;
            this.Unread = unread;
            this.Drafts = drafts;
            this.LastReceived = lastReceived;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inbox" /> class.
        /// </summary>
        public Inbox()
        {
        }

    }
}