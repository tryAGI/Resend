
#nullable enable

namespace Resend
{
    /// <summary>
    /// The event payload sent to the webhook endpoint.<br/>
    /// Example: {"type":"email.sent","created_at":"2026-08-22T15:28:00.000Z","data":{"email_id":"571f1f42-1c2d-4b1f-8f8e-8b3b5b3b5b3b","from":"onboarding@resend.dev","to":["delivered@resend.dev"],"subject":"Welcome","created_at":"2026-08-22T15:27:59.000Z"}}
    /// </summary>
    public sealed partial class GetWebhookEventResponsePayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}