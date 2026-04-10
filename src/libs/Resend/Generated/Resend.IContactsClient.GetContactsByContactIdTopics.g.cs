#nullable enable

namespace Resend
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Retrieve topics for a contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetContactTopicsResponseSuccess> GetContactsByContactIdTopicsAsync(
            string contactId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}