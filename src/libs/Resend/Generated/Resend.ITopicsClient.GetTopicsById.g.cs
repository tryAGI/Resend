#nullable enable

namespace Resend
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Retrieve a single topic
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetTopicResponseSuccess> GetTopicsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}