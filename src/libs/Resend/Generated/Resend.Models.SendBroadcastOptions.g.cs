
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendBroadcastOptions
    {
        /// <summary>
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public string? ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendBroadcastOptions" /> class.
        /// </summary>
        /// <param name="scheduledAt">
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendBroadcastOptions(
            string? scheduledAt)
        {
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendBroadcastOptions" /> class.
        /// </summary>
        public SendBroadcastOptions()
        {
        }
    }
}