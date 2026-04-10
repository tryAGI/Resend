#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Create a new domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateDomainResponse> CreateDomainsAsync(

            global::Resend.CreateDomainRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new domain
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
        /// <param name="trackingSubdomain">
        /// The subdomain to use for click and open tracking.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateDomainResponse> CreateDomainsAsync(
            string name,
            global::Resend.CreateDomainRequestRegion? region = default,
            string? customReturnPath = default,
            bool? openTracking = default,
            bool? clickTracking = default,
            global::Resend.CreateDomainRequestTls? tls = default,
            global::Resend.DomainCapabilities? capabilities = default,
            string? trackingSubdomain = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}