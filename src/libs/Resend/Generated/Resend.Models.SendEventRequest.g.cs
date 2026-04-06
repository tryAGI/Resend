
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendEventRequest
    {
        /// <summary>
        /// The name of the event to send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// The ID of the contact to associate with this event. Exactly one of `contact_id` or `email` must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public global::System.Guid? ContactId { get; set; }

        /// <summary>
        /// The email address to associate with this event. Exactly one of `contact_id` or `email` must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// An optional payload of key/value pairs to include with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEventRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendEventRequest(
            string @event,
            global::System.Guid? contactId,
            string? email,
            object? payload)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.ContactId = contactId;
            this.Email = email;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEventRequest" /> class.
        /// </summary>
        public SendEventRequest()
        {
        }
    }
}