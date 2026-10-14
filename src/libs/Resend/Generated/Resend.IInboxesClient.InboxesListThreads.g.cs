#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve a list of inbox threads<br/>
        /// Returns the threads in an inbox, most recently active first. A thread is a conversation made up of one or more emails. The `after` and `before` cursors take a thread ID, and only one of them can be passed. A cursor that is not a UUID, such as a date, returns a 422 validation_error. A cursor thread that is not in the selected folders returns a 404. To find threads by text, sender, recipient, attachment, or date, use the search threads endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListInboxThreadsResponseSuccess> InboxesListThreadsAsync(
            global::System.Guid inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of inbox threads<br/>
        /// Returns the threads in an inbox, most recently active first. A thread is a conversation made up of one or more emails. The `after` and `before` cursors take a thread ID, and only one of them can be passed. A cursor that is not a UUID, such as a date, returns a 422 validation_error. A cursor thread that is not in the selected folders returns a 404. To find threads by text, sender, recipient, attachment, or date, use the search threads endpoint.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxThreadsResponseSuccess>> InboxesListThreadsAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}