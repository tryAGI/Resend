#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update an existing inbox label<br/>
        /// Renames or recolors a label. Omitted fields keep their current value. A new name must not match another label on the inbox, compared without case, or the request returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="labelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxLabelResponseSuccess> InboxesUpdateLabelAsync(
            string inboxId,
            global::System.Guid labelId,

            global::Resend.UpdateInboxLabelOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox label<br/>
        /// Renames or recolors a label. Omitted fields keep their current value. A new name must not match another label on the inbox, compared without case, or the request returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="labelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateInboxLabelResponseSuccess>> InboxesUpdateLabelAsResponseAsync(
            string inboxId,
            global::System.Guid labelId,

            global::Resend.UpdateInboxLabelOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing inbox label<br/>
        /// Renames or recolors a label. Omitted fields keep their current value. A new name must not match another label on the inbox, compared without case, or the request returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="labelId"></param>
        /// <param name="name">
        /// A new name for the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Billing
        /// </param>
        /// <param name="color">
        /// A new color for the label, as a `#RRGGBB` hex color. It is stored in uppercase.<br/>
        /// Example: #F76B15
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxLabelResponseSuccess> InboxesUpdateLabelAsync(
            string inboxId,
            global::System.Guid labelId,
            string? name = default,
            string? color = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}