#nullable enable

namespace Resend
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Update an event
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateEventResponse> EditEventsByIdentifierAsync(
            string identifier,

            global::Resend.UpdateEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an event
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="schema">
        /// A flat key/type map defining the event payload schema. Set to `null` to clear the schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.UpdateEventResponse> EditEventsByIdentifierAsync(
            string identifier,
            object? schema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}