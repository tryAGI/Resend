#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Create a new segment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateSegmentResponseSuccess> CreateSegmentsAsync(

            global::Resend.CreateSegmentOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new segment
        /// </summary>
        /// <param name="name">
        /// The name of the segment.
        /// </param>
        /// <param name="filter">
        /// Filter conditions for the segment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateSegmentResponseSuccess> CreateSegmentsAsync(
            string name,
            object? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}