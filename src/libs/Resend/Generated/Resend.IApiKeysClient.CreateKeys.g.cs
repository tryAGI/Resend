#nullable enable

namespace Resend
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create a new API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateApiKeyResponse> CreateKeysAsync(

            global::Resend.CreateApiKeyRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key
        /// </summary>
        /// <param name="name">
        /// The API key name.
        /// </param>
        /// <param name="permission">
        /// The API key can have full access to Resend’s API or be only restricted to send emails. * full_access - Can create, delete, get, and update any resource. * sending_access - Can only send emails.
        /// </param>
        /// <param name="domainId">
        /// Restrict an API key to send emails only from a specific domain. Only used when the permission is sending_access.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateApiKeyResponse> CreateKeysAsync(
            string name,
            global::Resend.CreateApiKeyRequestPermission? permission = default,
            string? domainId = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}