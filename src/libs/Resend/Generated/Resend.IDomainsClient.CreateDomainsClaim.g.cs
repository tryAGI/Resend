#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Claim a domain<br/>
        /// Start a claim for a domain that another Resend account has already verified. The domain is recreated under your account with fresh DKIM keys, so the previous account's DNS records cannot be reused. Returns a TXT record to add to your DNS to prove ownership. Uses the same request body as creating a domain.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DomainClaim> CreateDomainsClaimAsync(

            global::Resend.CreateDomainClaimRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claim a domain<br/>
        /// Start a claim for a domain that another Resend account has already verified. The domain is recreated under your account with fresh DKIM keys, so the previous account's DNS records cannot be reused. Returns a TXT record to add to your DNS to prove ownership. Uses the same request body as creating a domain.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.DomainClaim>> CreateDomainsClaimAsResponseAsync(

            global::Resend.CreateDomainClaimRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claim a domain<br/>
        /// Start a claim for a domain that another Resend account has already verified. The domain is recreated under your account with fresh DKIM keys, so the previous account's DNS records cannot be reused. Returns a TXT record to add to your DNS to prove ownership. Uses the same request body as creating a domain.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DomainClaim> CreateDomainsClaimAsync(
            string name,
            global::Resend.CreateDomainClaimRequestRegion? region = default,
            string? customReturnPath = default,
            bool? openTracking = default,
            bool? clickTracking = default,
            string? trackingSubdomain = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}