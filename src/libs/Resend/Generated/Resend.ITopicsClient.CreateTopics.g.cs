#nullable enable

namespace Resend
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Create a new topic
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateTopicResponseSuccess> CreateTopicsAsync(

            global::Resend.CreateTopicOptions request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new topic
        /// </summary>
        /// <param name="name">
        /// The name of the topic. Max 50 characters.
        /// </param>
        /// <param name="defaultSubscription">
        /// The default subscription status for the topic. Cannot be changed after creation.
        /// </param>
        /// <param name="description">
        /// A description of the topic. Max 200 characters.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the topic. Public topics are visible to all contacts on the unsubscribe page. Private topics are only visible to opted-in contacts.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateTopicResponseSuccess> CreateTopicsAsync(
            string name,
            global::Resend.CreateTopicOptionsDefaultSubscription defaultSubscription,
            string? description = default,
            global::Resend.CreateTopicOptionsVisibility? visibility = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}