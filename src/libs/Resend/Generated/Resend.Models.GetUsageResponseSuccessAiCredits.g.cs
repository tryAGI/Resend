
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessAiCredits
    {
        /// <summary>
        /// AI credits consumed in the current period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The plan limit, or `null` when unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// When the AI credit balance next increases, as an ISO 8601 datetime, or `null` when unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_increase_at")]
        public string? NextIncreaseAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessAiCredits" /> class.
        /// </summary>
        /// <param name="used">
        /// AI credits consumed in the current period.
        /// </param>
        /// <param name="limit">
        /// The plan limit, or `null` when unlimited.
        /// </param>
        /// <param name="nextIncreaseAt">
        /// When the AI credit balance next increases, as an ISO 8601 datetime, or `null` when unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessAiCredits(
            int? used,
            int? limit,
            string? nextIncreaseAt)
        {
            this.Used = used;
            this.Limit = limit;
            this.NextIncreaseAt = nextIncreaseAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessAiCredits" /> class.
        /// </summary>
        public GetUsageResponseSuccessAiCredits()
        {
        }

    }
}