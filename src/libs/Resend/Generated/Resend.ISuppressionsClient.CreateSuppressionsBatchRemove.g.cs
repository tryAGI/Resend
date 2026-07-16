#nullable enable

namespace Resend
{
    public partial interface ISuppressionsClient
    {
        /// <summary>
        /// Remove up to 100 suppressions at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.BatchRemoveSuppressionsResponseSuccess> CreateSuppressionsBatchRemoveAsync(

            global::Resend.BatchRemoveSuppressionsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove up to 100 suppressions at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.BatchRemoveSuppressionsResponseSuccess>> CreateSuppressionsBatchRemoveAsResponseAsync(

            global::Resend.BatchRemoveSuppressionsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove up to 100 suppressions at once
        /// </summary>
        /// <param name="emails">
        /// Email addresses to remove from the suppression list.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </param>
        /// <param name="ids">
        /// Suppression IDs to remove from the suppression list.<br/>
        /// Example: [e169aa45-1ecf-4183-9955-b1499d5701d3]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.BatchRemoveSuppressionsResponseSuccess> CreateSuppressionsBatchRemoveAsync(
            global::System.Collections.Generic.IList<string>? emails = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}