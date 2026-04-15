
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainRecord
    {
        /// <summary>
        /// The type of record (SPF for sending, DKIM for sending, Receiving for inbound emails, Tracking &amp; TrackingCAA for click and open tracking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainRecordRecordJsonConverter))]
        public global::Resend.DomainRecordRecord? Record { get; set; }

        /// <summary>
        /// The name of the DNS record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The DNS record type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainRecordTypeJsonConverter))]
        public global::Resend.DomainRecordType? Type { get; set; }

        /// <summary>
        /// The time to live for the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// The status of the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainRecordStatusJsonConverter))]
        public global::Resend.DomainRecordStatus? Status { get; set; }

        /// <summary>
        /// The value of the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The priority of the record (only applicable for MX records).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainRecord" /> class.
        /// </summary>
        /// <param name="record">
        /// The type of record (SPF for sending, DKIM for sending, Receiving for inbound emails, Tracking &amp; TrackingCAA for click and open tracking).
        /// </param>
        /// <param name="name">
        /// The name of the DNS record.
        /// </param>
        /// <param name="type">
        /// The DNS record type.
        /// </param>
        /// <param name="ttl">
        /// The time to live for the record.
        /// </param>
        /// <param name="status">
        /// The status of the record.
        /// </param>
        /// <param name="value">
        /// The value of the record.
        /// </param>
        /// <param name="priority">
        /// The priority of the record (only applicable for MX records).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainRecord(
            global::Resend.DomainRecordRecord? record,
            string? name,
            global::Resend.DomainRecordType? type,
            string? ttl,
            global::Resend.DomainRecordStatus? status,
            string? value,
            int? priority)
        {
            this.Record = record;
            this.Name = name;
            this.Type = type;
            this.Ttl = ttl;
            this.Status = status;
            this.Value = value;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainRecord" /> class.
        /// </summary>
        public DomainRecord()
        {
        }
    }
}