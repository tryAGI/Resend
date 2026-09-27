
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessEmailsDaily
    {
        /// <summary>
        /// Emails sent and received in the current day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The daily plan limit, or `null` when the account has a monthly sending subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Emails sent today.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent")]
        public int? Sent { get; set; }

        /// <summary>
        /// Emails received today.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received")]
        public int? Received { get; set; }

        /// <summary>
        /// When the daily counter resets, as an ISO 8601 datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resets_at")]
        public string? ResetsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmailsDaily" /> class.
        /// </summary>
        /// <param name="used">
        /// Emails sent and received in the current day.
        /// </param>
        /// <param name="limit">
        /// The daily plan limit, or `null` when the account has a monthly sending subscription.
        /// </param>
        /// <param name="sent">
        /// Emails sent today.
        /// </param>
        /// <param name="received">
        /// Emails received today.
        /// </param>
        /// <param name="resetsAt">
        /// When the daily counter resets, as an ISO 8601 datetime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessEmailsDaily(
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
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmailsDaily" /> class.
        /// </summary>
        public GetUsageResponseSuccessEmailsDaily()
        {
        }

    }
}