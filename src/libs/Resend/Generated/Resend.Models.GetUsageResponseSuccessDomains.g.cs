
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessDomains
    {
        /// <summary>
        /// Domains currently added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The plan limit, or `null` when unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessDomains" /> class.
        /// </summary>
        /// <param name="used">
        /// Domains currently added.
        /// </param>
        /// <param name="limit">
        /// The plan limit, or `null` when unlimited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessDomains(
            int? used,
            int? limit)
        {
            this.Used = used;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessDomains" /> class.
        /// </summary>
        public GetUsageResponseSuccessDomains()
        {
        }

    }
}