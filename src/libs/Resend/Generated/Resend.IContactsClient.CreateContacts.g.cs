#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Create a new contact
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactResponseSuccess> CreateContactsAsync(

            global::Resend.CreateContactOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new contact
        /// </summary>
        /// <param name="email">
        /// Email address of the contact.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </param>
        /// <param name="firstName">
        /// First name of the contact.<br/>
        /// Example: Steve
        /// </param>
        /// <param name="lastName">
        /// Last name of the contact.<br/>
        /// Example: Wozniak
        /// </param>
        /// <param name="unsubscribed">
        /// The Contact's global subscription status. If set to true, the contact will be unsubscribed from all Broadcasts.<br/>
        /// Example: false
        /// </param>
        /// <param name="properties">
        /// A map of custom property keys and values to create.
        /// </param>
        /// <param name="segments">
        /// Array of segment IDs to add the contact to.
        /// </param>
        /// <param name="topics">
        /// Array of topic subscriptions for the contact.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactResponseSuccess> CreateContactsAsync(
            string email,
            string? firstName = default,
            string? lastName = default,
            bool? unsubscribed = default,
            object? properties = default,
            global::System.Collections.Generic.IList<string>? segments = default,
            global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? topics = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}