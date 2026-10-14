#nullable enable

namespace Resend
{
    public partial interface IInboxesClient
    {
        /// <summary>
        /// Retrieve a list of thread emails<br/>
        /// Returns the messages of a thread, oldest first. Pass the `id` of the last message as `after` to get the next, newer page. Pass the `id` of the first message as `before` to get the previous, older page. Passing both `after` and `before`, or a cursor that is not a UUID, returns a 422. A cursor that is not a message of the thread returns a 404.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListInboxThreadEmailsResponseSuccess> InboxesListThreadEmailsAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of thread emails<br/>
        /// Returns the messages of a thread, oldest first. Pass the `id` of the last message as `after` to get the next, newer page. Pass the `id` of the first message as `before` to get the previous, older page. Passing both `after` and `before`, or a cursor that is not a UUID, returns a 422. A cursor that is not a message of the thread returns a 404.
        /// </summary>
        /// <param name="inboxId"></param>
        /// <param name="threadId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.ListInboxThreadEmailsResponseSuccess>> InboxesListThreadEmailsAsResponseAsync(
            global::System.Guid inboxId,
            global::System.Guid threadId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}