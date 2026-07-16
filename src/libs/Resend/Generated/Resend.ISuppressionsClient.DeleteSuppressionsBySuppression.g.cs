#nullable enable

namespace Resend
{
    public partial interface ISuppressionsClient
    {
        /// <summary>
        /// Remove a single suppression by ID or email
        /// </summary>
        /// <param name="suppression"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveSuppressionResponseSuccess> DeleteSuppressionsBySuppressionAsync(
            string suppression,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a single suppression by ID or email
        /// </summary>
        /// <param name="suppression"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RemoveSuppressionResponseSuccess>> DeleteSuppressionsBySuppressionAsResponseAsync(
            string suppression,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}