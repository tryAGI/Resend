#nullable enable

namespace Resend
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Remove an existing API key
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DeleteApiKeyResponse> DeleteKeysByApiKeyIdAsync(
            string apiKeyId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}