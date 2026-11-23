#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Enable Forge for a domain<br/>
        /// Put a domain's sending on Resend Forge. The domain must be a sending domain: receive-only domains, domains on a dedicated IP, and domains with legacy DKIM get a `forge_unavailable` error. The response includes the DNS record Forge needs. Add it to your DNS and call the verify domain endpoint with `scope: ["forge"]`, then poll the retrieve domain endpoint until the Forge record's `status` is `verified`. The domain keeps sending through its current records while the Forge record verifies, so there is no interruption. Calling this endpoint again just returns the current state.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.Domain> DomainsEnableForgeAsync(
            string domainId,

            global::Resend.EnableForgeRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Forge for a domain<br/>
        /// Put a domain's sending on Resend Forge. The domain must be a sending domain: receive-only domains, domains on a dedicated IP, and domains with legacy DKIM get a `forge_unavailable` error. The response includes the DNS record Forge needs. Add it to your DNS and call the verify domain endpoint with `scope: ["forge"]`, then poll the retrieve domain endpoint until the Forge record's `status` is `verified`. The domain keeps sending through its current records while the Forge record verifies, so there is no interruption. Calling this endpoint again just returns the current state.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.Domain>> DomainsEnableForgeAsResponseAsync(
            string domainId,

            global::Resend.EnableForgeRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Forge for a domain<br/>
        /// Put a domain's sending on Resend Forge. The domain must be a sending domain: receive-only domains, domains on a dedicated IP, and domains with legacy DKIM get a `forge_unavailable` error. The response includes the DNS record Forge needs. Add it to your DNS and call the verify domain endpoint with `scope: ["forge"]`, then poll the retrieve domain endpoint until the Forge record's `status` is `verified`. The domain keeps sending through its current records while the Forge record verifies, so there is no interruption. Calling this endpoint again just returns the current state.
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="customReturnPath">
        /// The subdomain for the Forge Return-Path address, for example `forge` on `example.com` produces a `CNAME` record for `forge.example.com`. It must start with a letter, end with a letter or digit, and contain only letters, digits, and hyphens, and is stored lowercased. When omitted, Resend picks a subdomain that is free in your DNS. It is set once, when Forge is enabled, and cannot be changed afterwards. It cannot equal the domain's return path on the legacy engine, and the chosen host must not already have DNS records.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.Domain> DomainsEnableForgeAsync(
            string domainId,
            string? customReturnPath = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}