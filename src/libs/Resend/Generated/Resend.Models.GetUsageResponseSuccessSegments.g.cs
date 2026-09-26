
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessSegments
    {
        /// <summary>
        /// Segments currently created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The plan limit, or `null` when the account has a contacts subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessSegments" /> class.
        /// </summary>
        /// <param name="used">
        /// Segments currently created.
        /// </param>
        /// <param name="limit">
        /// The plan limit, or `null` when the account has a contacts subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessSegments(
            int? used,
            int? limit)
        {
            this.Used = used;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessSegments" /> class.
        /// </summary>
        public GetUsageResponseSuccessSegments()
        {
        }

    }
}