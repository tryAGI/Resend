#nullable enable

namespace Resend
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Send an event
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendEventResponse> CreateEventsSendAsync(

            global::Resend.SendEventRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an event
        /// </summary>
        /// <param name="event">
        /// The name of the event to send.
        /// </param>
        /// <param name="contactId">
        /// The ID of the contact to associate with this event. Exactly one of `contact_id` or `email` must be provided.
        /// </param>
        /// <param name="email">
        /// The email address to associate with this event. Exactly one of `contact_id` or `email` must be provided.
        /// </param>
        /// <param name="payload">
        /// An optional payload of key/value pairs to include with the event.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendEventResponse> CreateEventsSendAsync(
            string @event,
            global::System.Guid? contactId = default,
            string? email = default,
            object? payload = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}