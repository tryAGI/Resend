#nullable enable

namespace Resend
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update an existing API key
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateApiKeyResponse> ApiKeysUpdateAsync(
            string apiKeyId,

            global::Resend.UpdateApiKeyRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing API key
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateApiKeyResponse>> ApiKeysUpdateAsResponseAsync(
            string apiKeyId,

            global::Resend.UpdateApiKeyRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing API key
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="name">
        /// The API key name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateApiKeyResponse> ApiKeysUpdateAsync(
            string apiKeyId,
            string name,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}