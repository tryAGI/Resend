
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainEventData
    {
        /// <summary>
        /// Unique identifier for the domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The domain name (e.g., `example.com`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Aggregated verification status of the domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainEventDataStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.DomainEventDataStatus Status { get; set; }

        /// <summary>
        /// Timestamp when the domain was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// AWS region where the domain is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainEventDataRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.DomainEventDataRegion Region { get; set; }

        /// <summary>
        /// DNS records required for domain verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord> Records { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the domain.
        /// </param>
        /// <param name="name">
        /// The domain name (e.g., `example.com`).
        /// </param>
        /// <param name="status">
        /// Aggregated verification status of the domain.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the domain was created.
        /// </param>
        /// <param name="region">
        /// AWS region where the domain is configured.
        /// </param>
        /// <param name="records">
        /// DNS records required for domain verification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainEventData(
            string id,
            string name,
            global::Resend.DomainEventDataStatus status,
            global::System.DateTime createdAt,
            global::Resend.DomainEventDataRegion region,
            global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord> records)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Region = region;
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEventData" /> class.
        /// </summary>
        public DomainEventData()
        {
        }

    }
}