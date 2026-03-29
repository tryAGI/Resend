#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend
{
    public partial interface IBroadcastsClient
    {
        /// <summary>
        /// Update an existing broadcast
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateBroadcastResponseSuccess> EditBroadcastsByIdAsync(
            string id,

            global::Resend.UpdateBroadcastOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing broadcast
        /// </summary>
        /// <param name="id"></param>
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
        /// The preview text of the email.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateBroadcastResponseSuccess> EditBroadcastsByIdAsync(
            string id,
            string? name = default,
            string? segmentId = default,
            string? from = default,
            string? subject = default,
            global::System.Collections.Generic.IList<string>? replyTo = default,
            string? previewText = default,
            string? html = default,
            string? text = default,
            string? topicId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}