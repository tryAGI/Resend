#nullable enable

namespace Resend
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Update an existing topic
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateTopicResponseSuccess> EditTopicsByIdAsync(
            string id,

            global::Resend.UpdateTopicOptions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing topic
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// The name of the topic. Max 50 characters.
        /// </param>
        /// <param name="description">
        /// A description of the topic. Max 200 characters.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the topic.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateTopicResponseSuccess> EditTopicsByIdAsync(
            string id,
            string? name = default,
            string? description = default,
            global::Resend.UpdateTopicOptionsVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}