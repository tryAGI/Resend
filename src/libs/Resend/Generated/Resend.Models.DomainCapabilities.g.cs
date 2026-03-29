
#nullable enable

namespace Resend
{
    /// <summary>
    /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
    /// </summary>
    public sealed partial class DomainCapabilities
    {
        /// <summary>
        /// Enable or disable sending emails from this domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sending")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainCapabilitiesSendingJsonConverter))]
        public global::Resend.DomainCapabilitiesSending? Sending { get; set; }

        /// <summary>
        /// Enable or disable receiving emails to this domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiving")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.DomainCapabilitiesReceivingJsonConverter))]
        public global::Resend.DomainCapabilitiesReceiving? Receiving { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCapabilities" /> class.
        /// </summary>
        /// <param name="sending">
        /// Enable or disable sending emails from this domain.
        /// </param>
        /// <param name="receiving">
        /// Enable or disable receiving emails to this domain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainCapabilities(
            global::Resend.DomainCapabilitiesSending? sending,
            global::Resend.DomainCapabilitiesReceiving? receiving)
        {
            this.Sending = sending;
            this.Receiving = receiving;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCapabilities" /> class.
        /// </summary>
        public DomainCapabilities()
        {
        }
    }
}