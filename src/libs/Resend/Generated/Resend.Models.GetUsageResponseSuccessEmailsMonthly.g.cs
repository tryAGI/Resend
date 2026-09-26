
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessEmailsMonthly
    {
        /// <summary>
        /// Emails sent and received in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The monthly plan limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Emails sent this billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent")]
        public int? Sent { get; set; }

        /// <summary>
        /// Emails received this billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received")]
        public int? Received { get; set; }

        /// <summary>
        /// When the monthly counter resets, as an ISO 8601 datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resets_at")]
        public string? ResetsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmailsMonthly" /> class.
        /// </summary>
        /// <param name="used">
        /// Emails sent and received in the current billing period.
        /// </param>
        /// <param name="limit">
        /// The monthly plan limit.
        /// </param>
        /// <param name="sent">
        /// Emails sent this billing period.
        /// </param>
        /// <param name="received">
        /// Emails received this billing period.
        /// </param>
        /// <param name="resetsAt">
        /// When the monthly counter resets, as an ISO 8601 datetime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessEmailsMonthly(
            int? used,
            int? limit,
            int? sent,
            int? received,
            string? resetsAt)
        {
            this.Used = used;
            this.Limit = limit;
            this.Sent = sent;
            this.Received = received;
            this.ResetsAt = resetsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmailsMonthly" /> class.
        /// </summary>
        public GetUsageResponseSuccessEmailsMonthly()
        {
        }

    }
}