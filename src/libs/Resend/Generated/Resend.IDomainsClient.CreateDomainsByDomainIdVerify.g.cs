#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Verify an existing domain<br/>
        /// Triggers verification of the domain's DNS records including DKIM, SPF, and the tracking CNAME (if a tracking subdomain is configured).
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.VerifyDomainResponse> CreateDomainsByDomainIdVerifyAsync(
            string domainId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}