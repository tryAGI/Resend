#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Update the agent settings for an inbox<br/>
        /// Updates the agent settings of the inbox. The agent is created when the inbox has none. Omitted fields keep their current value.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxAgentResponseSuccess> InboxesUpdateAgentAsync(
            string inboxId,

            global::Resend.UpdateInboxAgentOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the agent settings for an inbox<br/>
        /// Updates the agent settings of the inbox. The agent is created when the inbox has none. Omitted fields keep their current value.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.UpdateInboxAgentResponseSuccess>> InboxesUpdateAgentAsResponseAsync(
            string inboxId,

            global::Resend.UpdateInboxAgentOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the agent settings for an inbox<br/>
        /// Updates the agent settings of the inbox. The agent is created when the inbox has none. Omitted fields keep their current value.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="instructions">
        /// Instructions the agent follows when it handles the threads of the inbox. Max 4000 characters. Leading and trailing whitespace is trimmed, and the trimmed value must not be empty. Send null to clear the instructions.<br/>
        /// Example: Answer refund questions yourself. Escalate legal threats.
        /// </param>
        /// <param name="tone">
        /// The tone the agent writes in. Send null to clear the tone.<br/>
        /// Example: concise_professional
        /// </param>
        /// <param name="actions">
        /// The actions the agent can take. Replaces the whole set. Duplicates are removed. Send an empty array to disable all actions. The old names `archive_thread` and `delete_thread` return a 422. Use `archive` and `move_to_trash`.<br/>
        /// Example: [draft_reply, add_labels]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateInboxAgentResponseSuccess> InboxesUpdateAgentAsync(
            string inboxId,
            string? instructions = default,
            global::Resend.UpdateInboxAgentOptionsTone? tone = default,
            global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsAction>? actions = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}