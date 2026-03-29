#nullable enable

namespace Resend
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Remove an existing API key
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKeysByApiKeyIdAsync(
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}