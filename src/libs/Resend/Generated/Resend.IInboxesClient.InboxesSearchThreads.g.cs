#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Search the threads of an inbox<br/>
        /// Finds threads by the text of their emails, who sent or received them, whether they have attachments, and their dates. Results are ordered by latest activity, newest first, and paginate like the list threads endpoint, so a cursor that is not a thread ID returns a 422. Search can be up to about a minute behind new emails. Different parameters combine, so a thread must match all of them. `folders`, `labels`, and `read` apply to the thread. `query`, `from`, `to`, `cc`, `bcc`, `has_attachment`, `start_date`, and `end_date` must all match the same email in the thread. When any of these email filters is set, the matching email must itself be in one of `folders`. For `sent`, that means an email the inbox sent. When more than 10,000 threads match, search covers the 10,000 with the newest matching email.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="query"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="hasAttachment"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SearchInboxThreadsResponseSuccess> InboxesSearchThreadsAsync(
            string inboxId,
            string? query = default,
            global::System.Collections.Generic.IList<string>? from = default,
            global::System.Collections.Generic.IList<string>? to = default,
            global::System.Collections.Generic.IList<string>? cc = default,
            global::System.Collections.Generic.IList<string>? bcc = default,
            bool? hasAttachment = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search the threads of an inbox<br/>
        /// Finds threads by the text of their emails, who sent or received them, whether they have attachments, and their dates. Results are ordered by latest activity, newest first, and paginate like the list threads endpoint, so a cursor that is not a thread ID returns a 422. Search can be up to about a minute behind new emails. Different parameters combine, so a thread must match all of them. `folders`, `labels`, and `read` apply to the thread. `query`, `from`, `to`, `cc`, `bcc`, `has_attachment`, `start_date`, and `end_date` must all match the same email in the thread. When any of these email filters is set, the matching email must itself be in one of `folders`. For `sent`, that means an email the inbox sent. When more than 10,000 threads match, search covers the 10,000 with the newest matching email.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="query"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="hasAttachment"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="folders"></param>
        /// <param name="labels"></param>
        /// <param name="read"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.SearchInboxThreadsResponseSuccess>> InboxesSearchThreadsAsResponseAsync(
            string inboxId,
            string? query = default,
            global::System.Collections.Generic.IList<string>? from = default,
            global::System.Collections.Generic.IList<string>? to = default,
            global::System.Collections.Generic.IList<string>? cc = default,
            global::System.Collections.Generic.IList<string>? bcc = default,
            bool? hasAttachment = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? folders = default,
            global::System.Collections.Generic.IList<global::System.Guid>? labels = default,
            bool? read = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}