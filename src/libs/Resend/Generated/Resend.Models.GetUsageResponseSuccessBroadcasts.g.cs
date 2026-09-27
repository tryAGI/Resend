
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessBroadcasts
    {
        /// <summary>
        /// Broadcasts sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// Always `null`; broadcasts aren't limited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public object? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessBroadcasts" /> class.
        /// </summary>
        /// <param name="used">
        /// Broadcasts sent.
        /// </param>
        /// <param name="limit">
        /// Always `null`; broadcasts aren't limited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessBroadcasts(
            int? used,
            object? limit)
        {
            this.Used = used;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessBroadcasts" /> class.
        /// </summary>
        public GetUsageResponseSuccessBroadcasts()
        {
        }

    }
}