#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Cancel the schedule of the e-mail.
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.Email> CreateEmailsByEmailIdCancelAsync(
            string emailId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}