#nullable enable

namespace Resend
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Verify an existing domain
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.VerifyDomainResponse> CreateDomainsByDomainIdVerifyAsync(
            string domainId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}