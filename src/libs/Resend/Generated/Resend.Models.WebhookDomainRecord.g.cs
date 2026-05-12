
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDomainRecord
    {
        /// <summary>
        /// The purpose of the DNS record (SPF and DKIM for sending; Receiving MX for inbound emails; Tracking and TrackingCAA for click and open tracking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookDomainRecordRecordJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookDomainRecordRecord Record { get; set; }

        /// <summary>
        /// DNS record name or subdomain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// DNS record value to be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// DNS record type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookDomainRecordTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookDomainRecordType Type { get; set; }

        /// <summary>
        /// Time to live for the DNS record (e.g., `Auto`, `60`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ttl { get; set; }

        /// <summary>
        /// Verification status of this specific record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookDomainRecordStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookDomainRecordStatus Status { get; set; }

        /// <summary>
        /// Priority value (only applicable for MX records).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDomainRecord" /> class.
        /// </summary>
        /// <param name="record">
        /// The purpose of the DNS record (SPF and DKIM for sending; Receiving MX for inbound emails; Tracking and TrackingCAA for click and open tracking).
        /// </param>
        /// <param name="name">
        /// DNS record name or subdomain.
        /// </param>
        /// <param name="value">
        /// DNS record value to be set.
        /// </param>
        /// <param name="type">
        /// DNS record type.
        /// </param>
        /// <param name="ttl">
        /// Time to live for the DNS record (e.g., `Auto`, `60`).
        /// </param>
        /// <param name="status">
        /// Verification status of this specific record.
        /// </param>
        /// <param name="priority">
        /// Priority value (only applicable for MX records).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDomainRecord(
            global::Resend.WebhookDomainRecordRecord record,
            string name,
            string value,
            global::Resend.WebhookDomainRecordType type,
            string ttl,
            global::Resend.WebhookDomainRecordStatus status,
            int? priority)
        {
            this.Record = record;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Ttl = ttl ?? throw new global::System.ArgumentNullException(nameof(ttl));
            this.Status = status;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDomainRecord" /> class.
        /// </summary>
        public WebhookDomainRecord()
        {
        }

    }
}