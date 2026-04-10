#nullable enable

namespace Resend
{
    public partial interface IContactPropertiesClient
    {
        /// <summary>
        /// Create a new contact property
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactPropertyResponseSuccess> CreateContactPropertiesAsync(

            global::Resend.CreateContactPropertyOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new contact property
        /// </summary>
        /// <param name="key">
        /// The property key. Max length is 50 characters. Only alphanumeric characters and underscores are allowed.
        /// </param>
        /// <param name="type">
        /// The property type.
        /// </param>
        /// <param name="fallbackValue">
        /// The default value to use when the property is not set for a contact. Must match the type specified in the type field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactPropertyResponseSuccess> CreateContactPropertiesAsync(
            string key,
            global::Resend.CreateContactPropertyOptionsType type,
            global::Resend.OneOf<string, double?>? fallbackValue = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}