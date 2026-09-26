
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessRateLimit
    {
        /// <summary>
        /// The number of requests allowed per `duration`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The rate-limit window, e.g. `'1000ms'`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessRateLimit" /> class.
        /// </summary>
        /// <param name="limit">
        /// The number of requests allowed per `duration`.
        /// </param>
        /// <param name="duration">
        /// The rate-limit window, e.g. `'1000ms'`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessRateLimit(
            int? limit,
            string? duration)
        {
            this.Limit = limit;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessRateLimit" /> class.
        /// </summary>
        public GetUsageResponseSuccessRateLimit()
        {
        }

    }
}