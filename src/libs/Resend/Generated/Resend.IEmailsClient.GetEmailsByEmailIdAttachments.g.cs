#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Retrieve a list of attachments for a sent email
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListAttachmentsResponse> GetEmailsByEmailIdAttachmentsAsync(
            global::System.Guid emailId,
            int? limit = default,
            global::System.Guid? after = default,
            global::System.Guid? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}