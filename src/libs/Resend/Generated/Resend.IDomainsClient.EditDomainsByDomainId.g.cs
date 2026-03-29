#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Update an existing domain
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateDomainResponseSuccess> EditDomainsByDomainIdAsync(
            string domainId,

            global::Resend.UpdateDomainOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing domain
        /// </summary>
        /// <param name="domainId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateDomainResponseSuccess> EditDomainsByDomainIdAsync(
            string domainId,
            bool? openTracking = default,
            bool? clickTracking = default,
            string? tls = default,
            global::Resend.DomainCapabilities? capabilities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}