#nullable enable

namespace Resend
{
    public partial interface IReceivingEmailsClient
    {
        /// <summary>
        /// Retrieve a single received email
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetReceivedEmailResponse> GetEmailsReceivingByEmailIdAsync(
            global::System.Guid emailId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}