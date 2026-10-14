#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Remove an existing inbox label<br/>
        /// Deletes the label and removes it from every thread that carries it.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="labelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveInboxLabelResponseSuccess> InboxesRemoveLabelAsync(
            global::System.Guid inboxId,
            global::System.Guid labelId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an existing inbox label<br/>
        /// Deletes the label and removes it from every thread that carries it.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="labelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.RemoveInboxLabelResponseSuccess>> InboxesRemoveLabelAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid labelId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}