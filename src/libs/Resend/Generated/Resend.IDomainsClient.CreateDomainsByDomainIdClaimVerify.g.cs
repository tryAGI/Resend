#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Verify a domain claim<br/>
        /// Trigger asynchronous DNS verification and ownership transfer for a domain claim. The claim stays `pending` while verification runs; poll the retrieve endpoint for status. Once `completed`, the transferred domain has new DKIM records that must be added to DNS and verified via the standard domain verify endpoint.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DomainClaim> CreateDomainsByDomainIdClaimVerifyAsync(
            string domainId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify a domain claim<br/>
        /// Trigger asynchronous DNS verification and ownership transfer for a domain claim. The claim stays `pending` while verification runs; poll the retrieve endpoint for status. Once `completed`, the transferred domain has new DKIM records that must be added to DNS and verified via the standard domain verify endpoint.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.DomainClaim>> CreateDomainsByDomainIdClaimVerifyAsResponseAsync(
            string domainId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}