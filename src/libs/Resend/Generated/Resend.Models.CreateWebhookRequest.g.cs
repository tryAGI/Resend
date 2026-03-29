
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookRequest
    {
        /// <summary>
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/handler
        /// </summary>
        /// <example>https://webhook.example.com/handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered, email.bounced]
        /// </summary>
        /// <example>[email.sent, email.delivered, email.bounced]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/handler
        /// </param>
        /// <param name="events">
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered, email.bounced]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookRequest(
            string endpoint,
            global::System.Collections.Generic.IList<string> events)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        public CreateWebhookRequest()
        {
        }
    }
}