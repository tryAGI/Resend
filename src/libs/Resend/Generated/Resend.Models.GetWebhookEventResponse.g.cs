
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebhookEventResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: webhook_event
        /// </summary>
        /// <example>webhook_event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the webhook event.<br/>
        /// Example: msg_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </summary>
        /// <example>msg_1srOrx2ZWZBpBUvZwXKQmoEYga2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of the event.<br/>
        /// Example: email.sent
        /// </summary>
        /// <example>email.sent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Timestamp indicating when the event was created.<br/>
        /// Example: 2026-08-22T15:28:00.000Z
        /// </summary>
        /// <example>2026-08-22T15:28:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The delivery status of the event for this webhook.<br/>
        /// Example: attempting
        /// </summary>
        /// <example>attempting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetWebhookEventResponseStatusJsonConverter))]
        public global::Resend.GetWebhookEventResponseStatus? Status { get; set; }

        /// <summary>
        /// Timestamp of the next scheduled delivery attempt, or null when none is scheduled. Always null once the event has succeeded or permanently failed.<br/>
        /// Example: 2026-08-22T15:33:00.000Z
        /// </summary>
        /// <example>2026-08-22T15:33:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_attempt_at")]
        public global::System.DateTime? NextAttemptAt { get; set; }

        /// <summary>
        /// The event payload sent to the webhook endpoint.<br/>
        /// Example: {"type":"email.sent","created_at":"2026-08-22T15:28:00.000Z","data":{"email_id":"571f1f42-1c2d-4b1f-8f8e-8b3b5b3b5b3b","from":"onboarding@resend.dev","to":["delivered@resend.dev"],"subject":"Welcome","created_at":"2026-08-22T15:27:59.000Z"}}
        /// </summary>
        /// <example>{"type":"email.sent","created_at":"2026-08-22T15:28:00.000Z","data":{"email_id":"571f1f42-1c2d-4b1f-8f8e-8b3b5b3b5b3b","from":"onboarding@resend.dev","to":["delivered@resend.dev"],"subject":"Welcome","created_at":"2026-08-22T15:27:59.000Z"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookEventResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: webhook_event
        /// </param>
        /// <param name="id">
        /// The ID of the webhook event.<br/>
        /// Example: msg_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </param>
        /// <param name="type">
        /// The type of the event.<br/>
        /// Example: email.sent
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the event was created.<br/>
        /// Example: 2026-08-22T15:28:00.000Z
        /// </param>
        /// <param name="status">
        /// The delivery status of the event for this webhook.<br/>
        /// Example: attempting
        /// </param>
        /// <param name="nextAttemptAt">
        /// Timestamp of the next scheduled delivery attempt, or null when none is scheduled. Always null once the event has succeeded or permanently failed.<br/>
        /// Example: 2026-08-22T15:33:00.000Z
        /// </param>
        /// <param name="payload">
        /// The event payload sent to the webhook endpoint.<br/>
        /// Example: {"type":"email.sent","created_at":"2026-08-22T15:28:00.000Z","data":{"email_id":"571f1f42-1c2d-4b1f-8f8e-8b3b5b3b5b3b","from":"onboarding@resend.dev","to":["delivered@resend.dev"],"subject":"Welcome","created_at":"2026-08-22T15:27:59.000Z"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWebhookEventResponse(
            string? @object,
            string? id,
            string? type,
            global::System.DateTime? createdAt,
            global::Resend.GetWebhookEventResponseStatus? status,
            global::System.DateTime? nextAttemptAt,
            object? payload)
        {
            this.Object = @object;
            this.Id = id;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.NextAttemptAt = nextAttemptAt;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookEventResponse" /> class.
        /// </summary>
        public GetWebhookEventResponse()
        {
        }

    }
}