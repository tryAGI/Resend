
#nullable enable

namespace Resend
{
    /// <summary>
    /// A single breakdown row. Which dimension fields are present depends on the requested `dimensions`; which metric fields are present depends on the requested `metrics`.
    /// </summary>
    public sealed partial class EmailMetricsDataRow
    {
        /// <summary>
        /// Present when `period` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public string? Period { get; set; }

        /// <summary>
        /// Present when `domain` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_id")]
        public global::System.Guid? DomainId { get; set; }

        /// <summary>
        /// Present when `domain` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_name")]
        public string? DomainName { get; set; }

        /// <summary>
        /// Present when `email` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_id")]
        public global::System.Guid? EmailId { get; set; }

        /// <summary>
        /// Present when `broadcast` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_id")]
        public global::System.Guid? BroadcastId { get; set; }

        /// <summary>
        /// Present when `broadcast` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_name")]
        public string? BroadcastName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMetricsDataRow" /> class.
        /// </summary>
        /// <param name="period">
        /// Present when `period` is in `dimensions`.
        /// </param>
        /// <param name="domainId">
        /// Present when `domain` is in `dimensions`.
        /// </param>
        /// <param name="domainName">
        /// Present when `domain` is in `dimensions`.
        /// </param>
        /// <param name="emailId">
        /// Present when `email` is in `dimensions`.
        /// </param>
        /// <param name="broadcastId">
        /// Present when `broadcast` is in `dimensions`.
        /// </param>
        /// <param name="broadcastName">
        /// Present when `broadcast` is in `dimensions`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailMetricsDataRow(
            string? period,
            global::System.Guid? domainId,
            string? domainName,
            global::System.Guid? emailId,
            global::System.Guid? broadcastId,
            string? broadcastName)
        {
            this.Period = period;
            this.DomainId = domainId;
            this.DomainName = domainName;
            this.EmailId = emailId;
            this.BroadcastId = broadcastId;
            this.BroadcastName = broadcastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMetricsDataRow" /> class.
        /// </summary>
        public EmailMetricsDataRow()
        {
        }

    }
}