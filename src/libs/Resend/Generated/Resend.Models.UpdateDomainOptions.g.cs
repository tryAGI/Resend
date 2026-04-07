
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDomainOptions
    {
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
        /// enforced | opportunistic.<br/>
        /// Default Value: opportunistic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tls")]
        public string? Tls { get; set; }

        /// <summary>
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Resend.DomainCapabilities? Capabilities { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateDomainOptions" /> class.
        /// </summary>
        /// <param name="openTracking">
        /// Track the open rate of each email.
        /// </param>
        /// <param name="clickTracking">
        /// Track clicks within the body of each HTML email.
        /// </param>
        /// <param name="tls">
        /// enforced | opportunistic.<br/>
        /// Default Value: opportunistic
        /// </param>
        /// <param name="capabilities">
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </param>
        /// <param name="trackingSubdomain">
        /// The subdomain to use for click and open tracking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDomainOptions(
            bool? openTracking,
            bool? clickTracking,
            string? tls,
            global::Resend.DomainCapabilities? capabilities,
            string? trackingSubdomain)
        {
            this.OpenTracking = openTracking;
            this.ClickTracking = clickTracking;
            this.Tls = tls;
            this.Capabilities = capabilities;
            this.TrackingSubdomain = trackingSubdomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainOptions" /> class.
        /// </summary>
        public UpdateDomainOptions()
        {
        }
    }
}