
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessAutomationRuns
    {
        /// <summary>
        /// Automation runs in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The plan limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// When the counter resets, as an ISO 8601 datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resets_at")]
        public string? ResetsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessAutomationRuns" /> class.
        /// </summary>
        /// <param name="used">
        /// Automation runs in the current billing period.
        /// </param>
        /// <param name="limit">
        /// The plan limit.
        /// </param>
        /// <param name="resetsAt">
        /// When the counter resets, as an ISO 8601 datetime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessAutomationRuns(
            int? used,
            int? limit,
            string? resetsAt)
        {
            this.Used = used;
            this.Limit = limit;
            this.ResetsAt = resetsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessAutomationRuns" /> class.
        /// </summary>
        public GetUsageResponseSuccessAutomationRuns()
        {
        }

    }
}