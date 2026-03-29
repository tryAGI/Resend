#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Update a single email
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateEmailOptions> EditEmailsByEmailIdAsync(
            string emailId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}