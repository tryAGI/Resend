#nullable enable

namespace Resend
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Remove an existing contact by ID or email
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveContactResponseSuccess> DeleteContactsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}