
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailSuppressedEventDataVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suppressed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventSuppressed Suppressed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSuppressedEventDataVariant2" /> class.
        /// </summary>
        /// <param name="suppressed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailSuppressedEventDataVariant2(
            global::Resend.WebhookEventSuppressed suppressed)
        {
            this.Suppressed = suppressed ?? throw new global::System.ArgumentNullException(nameof(suppressed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSuppressedEventDataVariant2" /> class.
        /// </summary>
        public EmailSuppressedEventDataVariant2()
        {
        }

    }
}