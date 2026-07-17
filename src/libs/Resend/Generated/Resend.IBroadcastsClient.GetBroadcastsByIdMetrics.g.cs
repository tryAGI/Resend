#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Retrieve aggregate metrics for a broadcast<br/>
        /// Delivery and engagement counters (each with a count and a rate) for a single broadcast. Opens and clicks are reported as unique counts. Rates divide by sent-so-far while the broadcast is still sending, then by the full audience once it has finished.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetBroadcastMetricsResponseSuccess> GetBroadcastsByIdMetricsAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve aggregate metrics for a broadcast<br/>
        /// Delivery and engagement counters (each with a count and a rate) for a single broadcast. Opens and clicks are reported as unique counts. Rates divide by sent-so-far while the broadcast is still sending, then by the full audience once it has finished.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.GetBroadcastMetricsResponseSuccess>> GetBroadcastsByIdMetricsAsResponseAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}