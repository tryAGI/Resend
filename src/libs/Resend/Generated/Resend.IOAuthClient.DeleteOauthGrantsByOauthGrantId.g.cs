#nullable enable

namespace Resend
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Revoke an OAuth grant
        /// </summary>
        /// <param name="oauthGrantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RevokeOAuthGrantResponse> DeleteOauthGrantsByOauthGrantIdAsync(
            string oauthGrantId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke an OAuth grant
        /// </summary>
        /// <param name="oauthGrantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RevokeOAuthGrantResponse>> DeleteOauthGrantsByOauthGrantIdAsResponseAsync(
            string oauthGrantId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}