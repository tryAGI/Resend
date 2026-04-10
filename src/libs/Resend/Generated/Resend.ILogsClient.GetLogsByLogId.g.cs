#nullable enable

namespace Resend
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Retrieve a single log
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.Log> GetLogsByLogIdAsync(
            global::System.Guid logId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}