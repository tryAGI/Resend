#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Create an inbox<br/>
        /// Creates an inbox that sends and receives email at an address on one of your domains. The domain must belong to the team. Without `forwarding`, the domain must have receiving enabled, with DKIM and SPF verified and the inbound MX record verified or pending. With `forwarding` set to `true`, the domain only needs DKIM and SPF verified for sending, and Resend generates a `receiving_address` on the team inbound domain, and a team without an inbound domain gets a 422. A domain that does not meet these rules returns a 422 validation_error. An address or receiving address that is already in use returns a 409. A team that has reached the inbox limit of its plan returns a 403 validation_error. A blocked account returns a 451.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxResponseSuccess> InboxesCreateAsync(

            global::Resend.CreateInboxOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an inbox<br/>
        /// Creates an inbox that sends and receives email at an address on one of your domains. The domain must belong to the team. Without `forwarding`, the domain must have receiving enabled, with DKIM and SPF verified and the inbound MX record verified or pending. With `forwarding` set to `true`, the domain only needs DKIM and SPF verified for sending, and Resend generates a `receiving_address` on the team inbound domain, and a team without an inbound domain gets a 422. A domain that does not meet these rules returns a 422 validation_error. An address or receiving address that is already in use returns a 409. A team that has reached the inbox limit of its plan returns a 403 validation_error. A blocked account returns a 451.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CreateInboxResponseSuccess>> InboxesCreateAsResponseAsync(

            global::Resend.CreateInboxOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an inbox<br/>
        /// Creates an inbox that sends and receives email at an address on one of your domains. The domain must belong to the team. Without `forwarding`, the domain must have receiving enabled, with DKIM and SPF verified and the inbound MX record verified or pending. With `forwarding` set to `true`, the domain only needs DKIM and SPF verified for sending, and Resend generates a `receiving_address` on the team inbound domain, and a team without an inbound domain gets a 422. A domain that does not meet these rules returns a 422 validation_error. An address or receiving address that is already in use returns a 409. A team that has reached the inbox limit of its plan returns a 403 validation_error. A blocked account returns a 451.
        /// </summary>
        /// <param name="emailAddress">
        /// The inbox email address on one of your domains. The API trims and lowercases it. The part before the `@` is at most 64 characters and contains only letters, numbers, and `. _ % -`. A `+` returns a 422. It cannot start or end with a dot or contain two dots in a row.<br/>
        /// Example: support@acme.com
        /// </param>
        /// <param name="name">
        /// Internal name for the inbox. Recipients do not see it. Max 64 characters. Defaults to `email_address`.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="fromName">
        /// The name recipients see when mail is sent from this inbox. A plain name, not a `Name &lt;email&gt;` address. Max 78 characters. It cannot contain a colon, `&lt;`, `&gt;`, line breaks, or other control characters. An email address inside the name must be on a domain the team has verified for sending. An empty string leaves it unset.<br/>
        /// Example: Ada from Support
        /// </param>
        /// <param name="forwarding">
        /// When `true`, Resend provisions a receiving address so you can receive mail without adding an MX record. The address is returned in `receiving_address`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxResponseSuccess> InboxesCreateAsync(
            string emailAddress,
            string? name = default,
            string? fromName = default,
            bool? forwarding = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}