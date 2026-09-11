#nullable enable

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Duplicate a broadcast<br/>
        /// Creates a new draft broadcast with the same segment, topic, sender, subject, reply-to, preview text, and content as the source. The copy is named after the source with " (copy)" appended, truncated to 70 characters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DuplicateBroadcastResponseSuccess> BroadcastsDuplicateAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a broadcast<br/>
        /// Creates a new draft broadcast with the same segment, topic, sender, subject, reply-to, preview text, and content as the source. The copy is named after the source with " (copy)" appended, truncated to 70 characters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.DuplicateBroadcastResponseSuccess>> BroadcastsDuplicateAsResponseAsync(
            global::System.Guid id,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}