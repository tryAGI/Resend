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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactTopicsResponseSuccess> EditContactsByContactIdTopicsAsync(
            string contactId,

            global::Resend.UpdateContactTopicsOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update topics for a contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="topics"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactTopicsResponseSuccess> EditContactsByContactIdTopicsAsync(
            string contactId,
            global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic> topics,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}