
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDomainClaimRequest
    {
        /// <summary>
        /// The name of the domain you want to claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The region where emails will be sent from. Possible values are us-east-1 | eu-west-1 | sa-east-1 | ap-northeast-1<br/>
        /// Default Value: us-east-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateDomainClaimRequestRegionJsonConverter))]
        public global::Resend.CreateDomainClaimRequestRegion? Region { get; set; }

        /// <summary>
        /// For advanced use cases, choose a subdomain for the Return-Path address. Defaults to 'send' (i.e., send.yourdomain.tld).<br/>
        /// Default Value: send
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_return_path")]
        public string? CustomReturnPath { get; set; }

        /// <summary>
        /// Track the open rate of each email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_tracking")]
        public bool? OpenTracking { get; set; }

        /// <summary>
        /// Track clicks within the body of each HTML email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click_tracking")]
        public bool? ClickTracking { get; set; }

        /// <summary>
        /// The subdomain to use for click and open tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking_subdomain")]
        public string? TrackingSubdomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainClaimRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the domain you want to claim.
        /// </param>
        /// <param name="region">
        /// The region where emails will be sent from. Possible values are us-east-1 | eu-west-1 | sa-east-1 | ap-northeast-1<br/>
        /// Default Value: us-east-1
        /// </param>
        /// <param name="customReturnPath">
        /// For advanced use cases, choose a subdomain for the Return-Path address. Defaults to 'send' (i.e., send.yourdomain.tld).<br/>
        /// Default Value: send
        /// </param>
        /// <param name="openTracking">
        /// Track the open rate of each email.
        /// </param>
        /// <param name="clickTracking">
        /// Track clicks within the body of each HTML email.
        /// </param>
        /// <param name="trackingSubdomain">
        /// The subdomain to use for click and open tracking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDomainClaimRequest(
            string name,
            global::Resend.CreateDomainClaimRequestRegion? region,
            string? customReturnPath,
            bool? openTracking,
            bool? clickTracking,
            string? trackingSubdomain)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region;
            this.CustomReturnPath = customReturnPath;
            this.OpenTracking = openTracking;
            this.ClickTracking = clickTracking;
            this.TrackingSubdomain = trackingSubdomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainClaimRequest" /> class.
        /// </summary>
        public CreateDomainClaimRequest()
        {
        }

    }
}