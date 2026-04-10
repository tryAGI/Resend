#nullable enable

namespace Resend
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Create an event
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateEventResponse> CreateEventsAsync(

            global::Resend.CreateEventRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an event
        /// </summary>
        /// <param name="name">
        /// The name of the event. Cannot start with the reserved `resend:` prefix.
        /// </param>
        /// <param name="schema">
        /// An optional flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateEventResponse> CreateEventsAsync(
            string name,
            object? schema = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}