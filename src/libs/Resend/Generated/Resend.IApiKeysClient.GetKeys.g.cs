#nullable enable

namespace Resend
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Retrieve a list of API keys
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListApiKeysResponse> GetKeysAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}