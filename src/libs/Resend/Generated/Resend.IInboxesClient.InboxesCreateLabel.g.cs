#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Create a label on an inbox<br/>
        /// A label is a named, colored tag that belongs to one inbox. An inbox can have at most 100 labels. Label names are unique per inbox, compared without case. A duplicate name or a full inbox returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxLabelResponseSuccess> InboxesCreateLabelAsync(
            global::System.Guid inboxId,

            global::Resend.CreateInboxLabelOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a label on an inbox<br/>
        /// A label is a named, colored tag that belongs to one inbox. An inbox can have at most 100 labels. Label names are unique per inbox, compared without case. A duplicate name or a full inbox returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CreateInboxLabelResponseSuccess>> InboxesCreateLabelAsResponseAsync(
            global::System.Guid inboxId,

            global::Resend.CreateInboxLabelOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a label on an inbox<br/>
        /// A label is a named, colored tag that belongs to one inbox. An inbox can have at most 100 labels. Label names are unique per inbox, compared without case. A duplicate name or a full inbox returns a 422 validation_error.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="name">
        /// The name of the label. Max 64 characters. Leading and trailing whitespace is trimmed. Must not match another label on the inbox, compared without case.<br/>
        /// Example: Urgent
        /// </param>
        /// <param name="color">
        /// The color of the label, as a `#RRGGBB` hex color. It is stored in uppercase. When omitted, a random color from the dashboard palette is used.<br/>
        /// Example: #E93D82
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateInboxLabelResponseSuccess> InboxesCreateLabelAsync(
            global::System.Guid inboxId,
            string name,
            string? color = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}