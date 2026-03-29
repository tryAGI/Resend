
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The secret key used to verify webhook payloads.<br/>
        /// Example: whsec_...
        /// </summary>
        /// <example>whsec_...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: webhook
        /// </param>
        /// <param name="id">
        /// The ID of the webhook.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
        /// <param name="signingSecret">
        /// The secret key used to verify webhook payloads.<br/>
        /// Example: whsec_...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookResponse(
            string? @object,
            global::System.Guid? id,
            string? signingSecret)
        {
            this.Object = @object;
            this.Id = id;
            this.SigningSecret = signingSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookResponse" /> class.
        /// </summary>
        public CreateWebhookResponse()
        {
        }
    }
}