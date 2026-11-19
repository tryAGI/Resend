#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Verify an existing domain<br/>
        /// Triggers verification of the domain's DNS records including DKIM, SPF, and the tracking CNAME (if a tracking subdomain is configured). Pass `scope` to limit the check to specific records.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.VerifyDomainResponse> DomainsVerifyAsync(
            string domainId,

            global::Resend.VerifyDomainOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify an existing domain<br/>
        /// Triggers verification of the domain's DNS records including DKIM, SPF, and the tracking CNAME (if a tracking subdomain is configured). Pass `scope` to limit the check to specific records.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.VerifyDomainResponse>> DomainsVerifyAsResponseAsync(
            string domainId,

            global::Resend.VerifyDomainOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify an existing domain<br/>
        /// Triggers verification of the domain's DNS records including DKIM, SPF, and the tracking CNAME (if a tracking subdomain is configured). Pass `scope` to limit the check to specific records.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="scope">
        /// Limit the check to specific records. The only supported value is `forge`: only the Forge record is checked, and the other records keep their current status. Requires Forge to be enabled on the domain, otherwise the endpoint responds with a `forge_not_enabled` error. When omitted, all records are checked.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.VerifyDomainResponse> DomainsVerifyAsync(
            string domainId,
            global::System.Collections.Generic.IList<global::Resend.VerifyDomainOptionsScopeItem>? scope = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}