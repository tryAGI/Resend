
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailClickedEventDataVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.WebhookEventClick Click { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClickedEventDataVariant2" /> class.
        /// </summary>
        /// <param name="click"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailClickedEventDataVariant2(
            global::Resend.WebhookEventClick click)
        {
            this.Click = click ?? throw new global::System.ArgumentNullException(nameof(click));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClickedEventDataVariant2" /> class.
        /// </summary>
        public EmailClickedEventDataVariant2()
        {
        }

    }
}