
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEventSuppressed
    {
        /// <summary>
        /// Array of SMTP diagnostic responses from the receiving server, one entry per recipient.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DiagnosticCode { get; set; }

        /// <summary>
        /// Detailed suppression message describing why the email was suppressed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Reason the address is suppressed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookEventSuppressedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventSuppressedReason Reason { get; set; }

        /// <summary>
        /// Suppression type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.WebhookEventSuppressedTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventSuppressedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventSuppressed" /> class.
        /// </summary>
        /// <param name="diagnosticCode">
        /// Array of SMTP diagnostic responses from the receiving server, one entry per recipient.
        /// </param>
        /// <param name="message">
        /// Detailed suppression message describing why the email was suppressed.
        /// </param>
        /// <param name="reason">
        /// Reason the address is suppressed.
        /// </param>
        /// <param name="type">
        /// Suppression type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventSuppressed(
            global::System.Collections.Generic.IList<string> diagnosticCode,
            string message,
            global::Resend.WebhookEventSuppressedReason reason,
            global::Resend.WebhookEventSuppressedType type)
        {
            this.DiagnosticCode = diagnosticCode ?? throw new global::System.ArgumentNullException(nameof(diagnosticCode));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventSuppressed" /> class.
        /// </summary>
        public WebhookEventSuppressed()
        {
        }

    }
}