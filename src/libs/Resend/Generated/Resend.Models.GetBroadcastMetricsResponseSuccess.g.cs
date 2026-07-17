
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBroadcastMetricsResponseSuccess
    {
        /// <summary>
        /// The response object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_id")]
        public global::System.Guid? BroadcastId { get; set; }

        /// <summary>
        /// Audience size the broadcast was sent to.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Emails sent so far (delivered + bounced while the broadcast is still sending).<br/>
        /// Example: 12000
        /// </summary>
        /// <example>12000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent")]
        public int? Sent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered")]
        public global::Resend.BroadcastMetricCounter? Delivered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opened")]
        public global::Resend.BroadcastMetricCounter? Opened { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clicked")]
        public global::Resend.BroadcastMetricCounter? Clicked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounced")]
        public global::Resend.BroadcastMetricCounter? Bounced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complained")]
        public global::Resend.BroadcastMetricCounter? Complained { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsubscribed")]
        public global::Resend.BroadcastMetricCounter? Unsubscribed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suppressed")]
        public global::Resend.BroadcastMetricCounter? Suppressed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBroadcastMetricsResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The response object type.
        /// </param>
        /// <param name="broadcastId">
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
        /// <param name="total">
        /// Audience size the broadcast was sent to.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="sent">
        /// Emails sent so far (delivered + bounced while the broadcast is still sending).<br/>
        /// Example: 12000
        /// </param>
        /// <param name="delivered"></param>
        /// <param name="opened"></param>
        /// <param name="clicked"></param>
        /// <param name="bounced"></param>
        /// <param name="complained"></param>
        /// <param name="unsubscribed"></param>
        /// <param name="suppressed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBroadcastMetricsResponseSuccess(
            string? @object,
            global::System.Guid? broadcastId,
            int? total,
            int? sent,
            global::Resend.BroadcastMetricCounter? delivered,
            global::Resend.BroadcastMetricCounter? opened,
            global::Resend.BroadcastMetricCounter? clicked,
            global::Resend.BroadcastMetricCounter? bounced,
            global::Resend.BroadcastMetricCounter? complained,
            global::Resend.BroadcastMetricCounter? unsubscribed,
            global::Resend.BroadcastMetricCounter? suppressed)
        {
            this.Object = @object;
            this.BroadcastId = broadcastId;
            this.Total = total;
            this.Sent = sent;
            this.Delivered = delivered;
            this.Opened = opened;
            this.Clicked = clicked;
            this.Bounced = bounced;
            this.Complained = complained;
            this.Unsubscribed = unsubscribed;
            this.Suppressed = suppressed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBroadcastMetricsResponseSuccess" /> class.
        /// </summary>
        public GetBroadcastMetricsResponseSuccess()
        {
        }

    }
}