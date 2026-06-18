
#nullable enable

namespace Resend
{
    /// <summary>
    /// The TXT record to add to your DNS to prove ownership of the claimed domain.
    /// </summary>
    public sealed partial class DomainClaimRecord
    {
        /// <summary>
        /// The DNS record type. Always TXT for domain claims.<br/>
        /// Example: TXT
        /// </summary>
        /// <example>TXT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainClaimRecordTypeJsonConverter))]
        public global::Resend.DomainClaimRecordType? Type { get; set; }

        /// <summary>
        /// The name of the DNS record (the domain being claimed).<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the TXT record.<br/>
        /// Example: resend-domain-verification=abc123
        /// </summary>
        /// <example>resend-domain-verification=abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The time to live for the record.<br/>
        /// Example: Auto
        /// </summary>
        /// <example>Auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainClaimRecord" /> class.
        /// </summary>
        /// <param name="type">
        /// The DNS record type. Always TXT for domain claims.<br/>
        /// Example: TXT
        /// </param>
        /// <param name="name">
        /// The name of the DNS record (the domain being claimed).<br/>
        /// Example: example.com
        /// </param>
        /// <param name="value">
        /// The value of the TXT record.<br/>
        /// Example: resend-domain-verification=abc123
        /// </param>
        /// <param name="ttl">
        /// The time to live for the record.<br/>
        /// Example: Auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainClaimRecord(
            global::Resend.DomainClaimRecordType? type,
            string? name,
            string? value,
            string? ttl)
        {
            this.Type = type;
            this.Name = name;
            this.Value = value;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainClaimRecord" /> class.
        /// </summary>
        public DomainClaimRecord()
        {
        }

    }
}