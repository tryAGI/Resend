#nullable enable

namespace Resend
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Update an existing segment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateSegmentResponseSuccess> SegmentsUpdateAsync(
            string id,

            global::Resend.UpdateSegmentOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing segment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateSegmentResponseSuccess>> SegmentsUpdateAsResponseAsync(
            string id,

            global::Resend.UpdateSegmentOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing segment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// The name of the segment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateSegmentResponseSuccess> SegmentsUpdateAsync(
            string id,
            string name,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}