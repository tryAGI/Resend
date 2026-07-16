#nullable enable

namespace Resend
{
    public partial interface ISuppressionsClient
    {
        /// <summary>
        /// Add up to 100 suppressions at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.BatchAddSuppressionsResponseSuccess> CreateSuppressionsBatchAddAsync(

            global::Resend.BatchAddSuppressionsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add up to 100 suppressions at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.BatchAddSuppressionsResponseSuccess>> CreateSuppressionsBatchAddAsResponseAsync(

            global::Resend.BatchAddSuppressionsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add up to 100 suppressions at once
        /// </summary>
        /// <param name="emails">
        /// Email addresses to suppress.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.BatchAddSuppressionsResponseSuccess> CreateSuppressionsBatchAddAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}