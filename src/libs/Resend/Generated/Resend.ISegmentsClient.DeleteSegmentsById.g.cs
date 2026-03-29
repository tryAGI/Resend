#nullable enable

namespace Resend
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Remove an existing segment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveSegmentResponseSuccess> DeleteSegmentsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}