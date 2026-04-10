#nullable enable

namespace Resend
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Update topics for a contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactTopicsResponseSuccess> EditContactsByContactIdTopicsAsync(
            string contactId,

            global::Resend.UpdateContactTopicsOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update topics for a contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="topics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactTopicsResponseSuccess> EditContactsByContactIdTopicsAsync(
            string contactId,
            global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic> topics,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}