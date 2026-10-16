#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve the agent settings for an inbox<br/>
        /// Returns the agent settings of the inbox. An inbox without a configured agent returns empty settings: `instructions` and `tone` are null and `actions` is an empty array.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.InboxAgent> InboxesGetAgentAsync(
            string inboxId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the agent settings for an inbox<br/>
        /// Returns the agent settings of the inbox. An inbox without a configured agent returns empty settings: `instructions` and `tone` are null and `actions` is an empty array.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.InboxAgent>> InboxesGetAgentAsResponseAsync(
            string inboxId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}