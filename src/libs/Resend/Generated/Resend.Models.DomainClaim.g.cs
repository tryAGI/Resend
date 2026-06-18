
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainClaim
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: domain_claim
        /// </summary>
        /// <example>domain_claim</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the claim.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the domain being claimed.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the claim.<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainClaimStatusJsonConverter))]
        public global::Resend.DomainClaimStatus? Status { get; set; }

        /// <summary>
        /// The ID of the placeholder domain created for the claim.<br/>
        /// Example: a1b2c3d4-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>a1b2c3d4-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_id")]
        public string? DomainId { get; set; }

        /// <summary>
        /// The region where the claimed domain will send from.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainClaimRegionJsonConverter))]
        public global::Resend.DomainClaimRegion? Region { get; set; }

        /// <summary>
        /// The TXT record to add to your DNS to prove ownership of the claimed domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        public global::Resend.DomainClaimRecord? Record { get; set; }

        /// <summary>
        /// Why the claim is currently blocked, if applicable.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainClaimBlockedReasonJsonConverter))]
        public global::Resend.DomainClaimBlockedReason? BlockedReason { get; set; }

        /// <summary>
        /// Why the claim failed, if applicable.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// The date and time the claim was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </summary>
        /// <example>2023-04-26T20:21:26.347412+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the claim expires if not verified.<br/>
        /// Example: 2023-05-03T20:21:26.347412+00:00
        /// </summary>
        /// <example>2023-05-03T20:21:26.347412+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainClaim" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: domain_claim
        /// </param>
        /// <param name="id">
        /// The ID of the claim.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="name">
        /// The name of the domain being claimed.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="status">
        /// The status of the claim.<br/>
        /// Example: pending
        /// </param>
        /// <param name="domainId">
        /// The ID of the placeholder domain created for the claim.<br/>
        /// Example: a1b2c3d4-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="region">
        /// The region where the claimed domain will send from.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="record">
        /// The TXT record to add to your DNS to prove ownership of the claimed domain.
        /// </param>
        /// <param name="blockedReason">
        /// Why the claim is currently blocked, if applicable.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="failureReason">
        /// Why the claim failed, if applicable.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="createdAt">
        /// The date and time the claim was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </param>
        /// <param name="expiresAt">
        /// The date and time the claim expires if not verified.<br/>
        /// Example: 2023-05-03T20:21:26.347412+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainClaim(
            string? @object,
            string? id,
            string? name,
            global::Resend.DomainClaimStatus? status,
            string? domainId,
            global::Resend.DomainClaimRegion? region,
            global::Resend.DomainClaimRecord? record,
            global::Resend.DomainClaimBlockedReason? blockedReason,
            string? failureReason,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt)
        {
            this.Object = @object;
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.DomainId = domainId;
            this.Region = region;
            this.Record = record;
            this.BlockedReason = blockedReason;
            this.FailureReason = failureReason;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainClaim" /> class.
        /// </summary>
        public DomainClaim()
        {
        }

    }
}