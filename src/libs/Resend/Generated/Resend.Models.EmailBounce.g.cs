
#nullable enable

namespace Resend
{
    /// <summary>
    /// Details about the bounce, present only when `last_event` is `bounced`.
    /// </summary>
    public sealed partial class EmailBounce
    {
        /// <summary>
        /// A human-readable message describing the bounce.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The type of bounce, as reported by AWS SES.<br/>
        /// Example: Permanent
        /// </summary>
        /// <example>Permanent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.EmailBounceTypeJsonConverter))]
        public global::Resend.EmailBounceType? Type { get; set; }

        /// <summary>
        /// The subtype of the bounce, as reported by AWS SES.<br/>
        /// Example: General
        /// </summary>
        /// <example>General</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.EmailBounceSubTypeJsonConverter))]
        public global::Resend.EmailBounceSubType? SubType { get; set; }

        /// <summary>
        /// Diagnostic codes returned by the receiving mail server for each bounced recipient.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticCode")]
        public global::System.Collections.Generic.IList<string>? DiagnosticCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBounce" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable message describing the bounce.
        /// </param>
        /// <param name="type">
        /// The type of bounce, as reported by AWS SES.<br/>
        /// Example: Permanent
        /// </param>
        /// <param name="subType">
        /// The subtype of the bounce, as reported by AWS SES.<br/>
        /// Example: General
        /// </param>
        /// <param name="diagnosticCode">
        /// Diagnostic codes returned by the receiving mail server for each bounced recipient.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailBounce(
            string? message,
            global::Resend.EmailBounceType? type,
            global::Resend.EmailBounceSubType? subType,
            global::System.Collections.Generic.IList<string>? diagnosticCode)
        {
            this.Message = message;
            this.Type = type;
            this.SubType = subType;
            this.DiagnosticCode = diagnosticCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBounce" /> class.
        /// </summary>
        public EmailBounce()
        {
        }

    }
}