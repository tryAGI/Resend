#nullable enable

namespace Resend
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Create a contact import
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactImportResponseSuccess> CreateContactsImportsAsync(

            global::Resend.CreateContactImportOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a contact import
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CreateContactImportResponseSuccess>> CreateContactsImportsAsResponseAsync(

            global::Resend.CreateContactImportOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a contact import
        /// </summary>
        /// <param name="file">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="filename">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="columnMap">
        /// JSON-encoded object mapping contact fields and custom property keys to CSV column names. Supports `email`, `first_name`, `last_name`, `unsubscribed`, and `properties`. Custom property mappings can include `type` as `string`, `number`, or `boolean`; defaults to `string`.<br/>
        /// Example: {"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}
        /// </param>
        /// <param name="onConflict">
        /// Strategy to use when an imported contact already exists.<br/>
        /// Default Value: skip<br/>
        /// Example: skip
        /// </param>
        /// <param name="onError">
        /// Strategy to use when an imported row fails validation.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </param>
        /// <param name="segments">
        /// JSON-encoded array of segments to add imported contacts to.<br/>
        /// Example: [{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]
        /// </param>
        /// <param name="topics">
        /// JSON-encoded array of topic subscriptions to apply to imported contacts. Each `subscription` must be `opt_in` or `opt_out`.<br/>
        /// Example: [{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactImportResponseSuccess> CreateContactsImportsAsync(
            byte[] file,
            string filename,
            string? columnMap = default,
            global::Resend.CreateContactImportOptionsOnConflict? onConflict = default,
            global::Resend.CreateContactImportOptionsOnError? onError = default,
            string? segments = default,
            string? topics = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a contact import
        /// </summary>
        /// <param name="file">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="filename">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="columnMap">
        /// JSON-encoded object mapping contact fields and custom property keys to CSV column names. Supports `email`, `first_name`, `last_name`, `unsubscribed`, and `properties`. Custom property mappings can include `type` as `string`, `number`, or `boolean`; defaults to `string`.<br/>
        /// Example: {"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}
        /// </param>
        /// <param name="onConflict">
        /// Strategy to use when an imported contact already exists.<br/>
        /// Default Value: skip<br/>
        /// Example: skip
        /// </param>
        /// <param name="onError">
        /// Strategy to use when an imported row fails validation.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </param>
        /// <param name="segments">
        /// JSON-encoded array of segments to add imported contacts to.<br/>
        /// Example: [{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]
        /// </param>
        /// <param name="topics">
        /// JSON-encoded array of topic subscriptions to apply to imported contacts. Each `subscription` must be `opt_in` or `opt_out`.<br/>
        /// Example: [{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateContactImportResponseSuccess> CreateContactsImportsAsync(
            global::System.IO.Stream file,
            string filename,
            string? columnMap = default,
            global::Resend.CreateContactImportOptionsOnConflict? onConflict = default,
            global::Resend.CreateContactImportOptionsOnError? onError = default,
            string? segments = default,
            string? topics = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a contact import
        /// </summary>
        /// <param name="file">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="filename">
        /// CSV file to import. Maximum size is 50MB.
        /// </param>
        /// <param name="columnMap">
        /// JSON-encoded object mapping contact fields and custom property keys to CSV column names. Supports `email`, `first_name`, `last_name`, `unsubscribed`, and `properties`. Custom property mappings can include `type` as `string`, `number`, or `boolean`; defaults to `string`.<br/>
        /// Example: {"email":"Email","first_name":"First Name","last_name":"Last Name","unsubscribed":"Unsubscribed","properties":{"plan":{"column":"Plan","type":"string"}}}
        /// </param>
        /// <param name="onConflict">
        /// Strategy to use when an imported contact already exists.<br/>
        /// Default Value: skip<br/>
        /// Example: skip
        /// </param>
        /// <param name="onError">
        /// Strategy to use when an imported row fails validation.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </param>
        /// <param name="segments">
        /// JSON-encoded array of segments to add imported contacts to.<br/>
        /// Example: [{"id":"78261eea-8f8b-4381-83c6-79fa7120f1cf"}]
        /// </param>
        /// <param name="topics">
        /// JSON-encoded array of topic subscriptions to apply to imported contacts. Each `subscription` must be `opt_in` or `opt_out`.<br/>
        /// Example: [{"id":"b6d24b8e-af0b-4c3c-be0c-359bbd97381e","subscription":"opt_in"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CreateContactImportResponseSuccess>> CreateContactsImportsAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? columnMap = default,
            global::Resend.CreateContactImportOptionsOnConflict? onConflict = default,
            global::Resend.CreateContactImportOptionsOnError? onError = default,
            string? segments = default,
            string? topics = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}