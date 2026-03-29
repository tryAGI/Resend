#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Retrieve a single attachment for a sent email
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RetrievedAttachment> GetEmailsByEmailIdAttachmentsByAttachmentIdAsync(
            global::System.Guid emailId,
            global::System.Guid attachmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}