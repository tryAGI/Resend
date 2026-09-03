
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplayWebhookEventResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: webhook_event
        /// </summary>
        /// <example>webhook_event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the replayed webhook event.<br/>
        /// Example: msg_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </summary>
        /// <example>msg_1srOrx2ZWZBpBUvZwXKQmoEYga2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhookEventResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: webhook_event
        /// </param>
        /// <param name="id">
        /// The ID of the replayed webhook event.<br/>
        /// Example: msg_1srOrx2ZWZBpBUvZwXKQmoEYga2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplayWebhookEventResponse(
            string? @object,
            string? id)
        {
            this.Object = @object;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhookEventResponse" /> class.
        /// </summary>
        public ReplayWebhookEventResponse()
        {
        }

    }
}