
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListWebhookEventsResponseDataItem
    {
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
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ListWebhookEventsResponseDataItemStatusJsonConverter))]
        public global::Resend.ListWebhookEventsResponseDataItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEventsResponseDataItem" /> class.
        /// </summary>
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
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebhookEventsResponseDataItem(
            string? id,
            string? type,
            global::System.DateTime? createdAt,
            global::Resend.ListWebhookEventsResponseDataItemStatus? status)
        {
            this.Id = id;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEventsResponseDataItem" /> class.
        /// </summary>
        public ListWebhookEventsResponseDataItem()
        {
        }

    }
}