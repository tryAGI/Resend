
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWebhooksResponseDataItem
    {
        /// <summary>
        /// The ID of the webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The URL where webhook events are sent.<br/>
        /// Example: https://webhook.example.com/handler
        /// </summary>
        /// <example>https://webhook.example.com/handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Array of event types subscribed to.<br/>
        /// Example: [email.sent]
        /// </summary>
        /// <example>[email.sent]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// The status of the webhook.<br/>
        /// Example: enabled
        /// </summary>
        /// <example>enabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Timestamp indicating when the webhook was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
        /// <param name="endpoint">
        /// The URL where webhook events are sent.<br/>
        /// Example: https://webhook.example.com/handler
        /// </param>
        /// <param name="events">
        /// Array of event types subscribed to.<br/>
        /// Example: [email.sent]
        /// </param>
        /// <param name="status">
        /// The status of the webhook.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the webhook was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebhooksResponseDataItem(
            global::System.Guid? id,
            string? endpoint,
            global::System.Collections.Generic.IList<string>? events,
            string? status,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Endpoint = endpoint;
            this.Events = events;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhooksResponseDataItem" /> class.
        /// </summary>
        public ListWebhooksResponseDataItem()
        {
        }
    }
}