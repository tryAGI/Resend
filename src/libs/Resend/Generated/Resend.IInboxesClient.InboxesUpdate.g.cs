#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update an existing inbox by ID or email address<br/>
        /// Updates the internal name of the inbox or the name recipients see when mail is sent from it. At least one of `name` or `from_name` is required.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxResponseSuccess> InboxesUpdateAsync(
            string inboxId,

            global::Resend.UpdateInboxOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox by ID or email address<br/>
        /// Updates the internal name of the inbox or the name recipients see when mail is sent from it. At least one of `name` or `from_name` is required.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateInboxResponseSuccess>> InboxesUpdateAsResponseAsync(
            string inboxId,

            global::Resend.UpdateInboxOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox by ID or email address<br/>
        /// Updates the internal name of the inbox or the name recipients see when mail is sent from it. At least one of `name` or `from_name` is required.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="name">
        /// New internal name for the inbox. Recipients do not see it. Between 1 and 64 characters after trimming.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="fromName">
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string removes it.<br/>
        /// Example: Ada from Support
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxResponseSuccess> InboxesUpdateAsync(
            string inboxId,
            string? name = default,
            string? fromName = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}