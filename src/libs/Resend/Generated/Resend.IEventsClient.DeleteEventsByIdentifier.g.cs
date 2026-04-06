#nullable enable

namespace Resend
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Delete an event
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.RemoveEventResponse> DeleteEventsByIdentifierAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}