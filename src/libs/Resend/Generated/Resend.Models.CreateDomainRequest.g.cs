
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDomainRequest
    {
        /// <summary>
        /// The name of the domain you want to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The region where emails will be sent from. Possible values are us-east-1 | eu-west-1 | sa-east-1 | ap-northeast-1<br/>
        /// Default Value: us-east-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateDomainRequestRegionJsonConverter))]
        public global::Resend.CreateDomainRequestRegion? Region { get; set; }

        /// <summary>
        /// For advanced use cases, choose a subdomain for the Return-Path address. Defaults to 'send' (i.e., send.yourdomain.tld).
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
        /// TLS mode. Opportunistic attempts secure connection but falls back to unencrypted. Enforced requires TLS or email won't be sent.<br/>
        /// Default Value: opportunistic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateDomainRequestTlsJsonConverter))]
        public global::Resend.CreateDomainRequestTls? Tls { get; set; }

        /// <summary>
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Resend.DomainCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the domain you want to create.
        /// </param>
        /// <param name="region">
        /// The region where emails will be sent from. Possible values are us-east-1 | eu-west-1 | sa-east-1 | ap-northeast-1<br/>
        /// Default Value: us-east-1
        /// </param>
        /// <param name="customReturnPath">
        /// For advanced use cases, choose a subdomain for the Return-Path address. Defaults to 'send' (i.e., send.yourdomain.tld).
        /// </param>
        /// <param name="openTracking">
        /// Track the open rate of each email.
        /// </param>
        /// <param name="clickTracking">
        /// Track clicks within the body of each HTML email.
        /// </param>
        /// <param name="tls">
        /// TLS mode. Opportunistic attempts secure connection but falls back to unencrypted. Enforced requires TLS or email won't be sent.<br/>
        /// Default Value: opportunistic
        /// </param>
        /// <param name="capabilities">
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDomainRequest(
            string name,
            global::Resend.CreateDomainRequestRegion? region,
            string? customReturnPath,
            bool? openTracking,
            bool? clickTracking,
            global::Resend.CreateDomainRequestTls? tls,
            global::Resend.DomainCapabilities? capabilities)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region;
            this.CustomReturnPath = customReturnPath;
            this.OpenTracking = openTracking;
            this.ClickTracking = clickTracking;
            this.Tls = tls;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        public CreateDomainRequest()
        {
        }
    }
}