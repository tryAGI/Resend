#nullable enable

namespace Resend
{
    public partial interface IContactPropertiesClient
    {
        /// <summary>
        /// Update an existing contact property
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactPropertyResponseSuccess> EditContactPropertiesByIdAsync(
            string id,

            global::Resend.UpdateContactPropertyOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing contact property
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fallbackValue">
        /// The default value to use when the property is not set for a contact. Must match the type of the property.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateContactPropertyResponseSuccess> EditContactPropertiesByIdAsync(
            string id,
            global::Resend.OneOf<string, double?>? fallbackValue = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}