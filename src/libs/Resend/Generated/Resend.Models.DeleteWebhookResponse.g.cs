
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWebhookResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the deleted webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Indicates whether the webhook was successfully deleted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: webhook
        /// </param>
        /// <param name="id">
        /// The ID of the deleted webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the webhook was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWebhookResponse(
            string? @object,
            global::System.Guid? id,
            bool? deleted)
        {
            this.Object = @object;
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse" /> class.
        /// </summary>
        public DeleteWebhookResponse()
        {
        }
    }
}