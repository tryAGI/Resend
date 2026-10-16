#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve a single inbox thread<br/>
        /// Returns the thread summary. The emails in the thread are listed with the list thread emails endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxThreadSummary> InboxesGetThreadAsync(
            string inboxId,
            global::System.Guid threadId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a single inbox thread<br/>
        /// Returns the thread summary. The emails in the thread are listed with the list thread emails endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxThreadSummary>> InboxesGetThreadAsResponseAsync(
            string inboxId,
            global::System.Guid threadId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}