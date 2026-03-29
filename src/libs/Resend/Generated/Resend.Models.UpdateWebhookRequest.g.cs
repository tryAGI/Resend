
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebhookRequest
    {
        /// <summary>
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/new-handler
        /// </summary>
        /// <example>https://webhook.example.com/new-handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered]
        /// </summary>
        /// <example>[email.sent, email.delivered]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// The status of the webhook.<br/>
        /// Example: enabled
        /// </summary>
        /// <example>enabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateWebhookRequestStatusJsonConverter))]
        public global::Resend.UpdateWebhookRequestStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// The URL where webhook events will be sent.<br/>
        /// Example: https://webhook.example.com/new-handler
        /// </param>
        /// <param name="events">
        /// Array of event types to subscribe to.<br/>
        /// Example: [email.sent, email.delivered]
        /// </param>
        /// <param name="status">
        /// The status of the webhook.<br/>
        /// Example: enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookRequest(
            string? endpoint,
            global::System.Collections.Generic.IList<string>? events,
            global::Resend.UpdateWebhookRequestStatus? status)
        {
            this.Endpoint = endpoint;
            this.Events = events;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        public UpdateWebhookRequest()
        {
        }
    }
}