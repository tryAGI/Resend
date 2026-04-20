
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Domain
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: domain
        /// </summary>
        /// <example>domain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the domain.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the domain.<br/>
        /// Example: not_started
        /// </summary>
        /// <example>not_started</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainStatusJsonConverter))]
        public global::Resend.DomainStatus? Status { get; set; }

        /// <summary>
        /// The date and time the domain was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </summary>
        /// <example>2023-04-26T20:21:26.347412+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The region where the domain is hosted.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Whether open tracking is enabled for this domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_tracking")]
        public bool? OpenTracking { get; set; }

        /// <summary>
        /// Whether click tracking is enabled for this domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click_tracking")]
        public bool? ClickTracking { get; set; }

        /// <summary>
        /// The subdomain used for click and open tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking_subdomain")]
        public string? TrackingSubdomain { get; set; }

        /// <summary>
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Resend.DomainCapabilities? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Records { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: domain
        /// </param>
        /// <param name="id">
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="name">
        /// The name of the domain.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="status">
        /// The status of the domain.<br/>
        /// Example: not_started
        /// </param>
        /// <param name="createdAt">
        /// The date and time the domain was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </param>
        /// <param name="region">
        /// The region where the domain is hosted.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="openTracking">
        /// Whether open tracking is enabled for this domain.
        /// </param>
        /// <param name="clickTracking">
        /// Whether click tracking is enabled for this domain.
        /// </param>
        /// <param name="trackingSubdomain">
        /// The subdomain used for click and open tracking.
        /// </param>
        /// <param name="capabilities">
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </param>
        /// <param name="records"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Domain(
            string? @object,
            string? id,
            string? name,
            global::Resend.DomainStatus? status,
            global::System.DateTime? createdAt,
            string? region,
            bool? openTracking,
            bool? clickTracking,
            string? trackingSubdomain,
            global::Resend.DomainCapabilities? capabilities,
            global::System.Collections.Generic.IList<global::Resend.DomainRecord>? records)
        {
            this.Object = @object;
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Region = region;
            this.OpenTracking = openTracking;
            this.ClickTracking = clickTracking;
            this.TrackingSubdomain = trackingSubdomain;
            this.Capabilities = capabilities;
            this.Records = records;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        public Domain()
        {
        }
    }
}