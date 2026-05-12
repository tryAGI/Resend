
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEventBounce
    {
        /// <summary>
        /// Array of SMTP diagnostic responses from the receiving server, one entry per recipient (e.g., `smtp; 550 5.1.1 user unknown`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DiagnosticCode { get; set; }

        /// <summary>
        /// Detailed bounce message describing why the email bounced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Bounce sub-type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookEventBounceSubTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventBounceSubType SubType { get; set; }

        /// <summary>
        /// Bounce type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookEventBounceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventBounceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventBounce" /> class.
        /// </summary>
        /// <param name="diagnosticCode">
        /// Array of SMTP diagnostic responses from the receiving server, one entry per recipient (e.g., `smtp; 550 5.1.1 user unknown`).
        /// </param>
        /// <param name="message">
        /// Detailed bounce message describing why the email bounced.
        /// </param>
        /// <param name="subType">
        /// Bounce sub-type.
        /// </param>
        /// <param name="type">
        /// Bounce type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventBounce(
            global::System.Collections.Generic.IList<string> diagnosticCode,
            string message,
            global::Resend.WebhookEventBounceSubType subType,
            global::Resend.WebhookEventBounceType type)
        {
            this.DiagnosticCode = diagnosticCode ?? throw new global::System.ArgumentNullException(nameof(diagnosticCode));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.SubType = subType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventBounce" /> class.
        /// </summary>
        public WebhookEventBounce()
        {
        }

    }
}