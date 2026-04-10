#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Create a broadcast
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateBroadcastResponseSuccess> CreateBroadcastsAsync(

            global::Resend.CreateBroadcastOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a broadcast
        /// </summary>
        /// <param name="name">
        /// Name of the broadcast.
        /// </param>
        /// <param name="segmentId">
        /// Unique identifier of the segment this broadcast will be sent to.
        /// </param>
        /// <param name="from">
        /// The email address of the sender.
        /// </param>
        /// <param name="subject">
        /// The subject line of the email.
        /// </param>
        /// <param name="replyTo">
        /// The email addresses to which replies should be sent.
        /// </param>
        /// <param name="previewText">
        /// The preview text of the email.<br/>
        /// Example: Here are our announcements
        /// </param>
        /// <param name="html">
        /// The HTML version of the message.
        /// </param>
        /// <param name="text">
        /// The plain text version of the message.
        /// </param>
        /// <param name="topicId">
        /// The topic ID that the broadcast will be scoped to.
        /// </param>
        /// <param name="send">
        /// Whether to send the broadcast immediately or keep it as a draft.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule time to send the broadcast. Can only be used if `send` is true.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateBroadcastResponseSuccess> CreateBroadcastsAsync(
            string segmentId,
            string from,
            string subject,
            string? name = default,
            global::System.Collections.Generic.IList<string>? replyTo = default,
            string? previewText = default,
            string? html = default,
            string? text = default,
            string? topicId = default,
            bool? send = default,
            string? scheduledAt = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}