
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEventClick
    {
        /// <summary>
        /// IP address of the user who clicked the link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipAddress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IpAddress { get; set; }

        /// <summary>
        /// The URL that was clicked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Link { get; set; }

        /// <summary>
        /// Timestamp when the click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// User agent string of the browser that clicked the link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventClick" /> class.
        /// </summary>
        /// <param name="ipAddress">
        /// IP address of the user who clicked the link.
        /// </param>
        /// <param name="link">
        /// The URL that was clicked.
        /// </param>
        /// <param name="timestamp">
        /// Timestamp when the click occurred.
        /// </param>
        /// <param name="userAgent">
        /// User agent string of the browser that clicked the link.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventClick(
            string ipAddress,
            string link,
            global::System.DateTime timestamp,
            string userAgent)
        {
            this.IpAddress = ipAddress ?? throw new global::System.ArgumentNullException(nameof(ipAddress));
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
            this.Timestamp = timestamp;
            this.UserAgent = userAgent ?? throw new global::System.ArgumentNullException(nameof(userAgent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventClick" /> class.
        /// </summary>
        public WebhookEventClick()
        {
        }

    }
}