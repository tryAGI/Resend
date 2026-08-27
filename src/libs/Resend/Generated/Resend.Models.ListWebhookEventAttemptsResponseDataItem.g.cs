
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListWebhookEventAttemptsResponseDataItem
    {
        /// <summary>
        /// The ID of the webhook event attempt.<br/>
        /// Example: atmpt_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </summary>
        /// <example>atmpt_1srOrx2ZWZBpBUvZwXKQmoEYga2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The HTTP status code returned by the webhook endpoint.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The response body returned by the webhook endpoint.<br/>
        /// Example: {"ok":true}
        /// </summary>
        /// <example>{"ok":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public string? Response { get; set; }

        /// <summary>
        /// Timestamp indicating when the attempt was sent.<br/>
        /// Example: 2026-08-22T15:33:12.000Z
        /// </summary>
        /// <example>2026-08-22T15:33:12.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_at")]
        public global::System.DateTime? SentAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEventAttemptsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook event attempt.<br/>
        /// Example: atmpt_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </param>
        /// <param name="httpStatusCode">
        /// The HTTP status code returned by the webhook endpoint.<br/>
        /// Example: 200
        /// </param>
        /// <param name="response">
        /// The response body returned by the webhook endpoint.<br/>
        /// Example: {"ok":true}
        /// </param>
        /// <param name="sentAt">
        /// Timestamp indicating when the attempt was sent.<br/>
        /// Example: 2026-08-22T15:33:12.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebhookEventAttemptsResponseDataItem(
            string? id,
            int? httpStatusCode,
            string? response,
            global::System.DateTime? sentAt)
        {
            this.Id = id;
            this.HttpStatusCode = httpStatusCode;
            this.Response = response;
            this.SentAt = sentAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEventAttemptsResponseDataItem" /> class.
        /// </summary>
        public ListWebhookEventAttemptsResponseDataItem()
        {
        }

    }
}