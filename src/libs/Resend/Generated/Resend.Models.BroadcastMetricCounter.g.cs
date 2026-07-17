
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BroadcastMetricCounter
    {
        /// <summary>
        /// Absolute number of events.<br/>
        /// Example: 11800
        /// </summary>
        /// <example>11800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Percentage this metric represents of its denominator: sent-so-far (delivered + bounced) while the broadcast is still sending, or the full audience once it has finished. For example, 11,800 delivered out of 12,000 sent gives a rate of 98.3.<br/>
        /// Example: 98.3
        /// </summary>
        /// <example>98.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastMetricCounter" /> class.
        /// </summary>
        /// <param name="count">
        /// Absolute number of events.<br/>
        /// Example: 11800
        /// </param>
        /// <param name="rate">
        /// Percentage this metric represents of its denominator: sent-so-far (delivered + bounced) while the broadcast is still sending, or the full audience once it has finished. For example, 11,800 delivered out of 12,000 sent gives a rate of 98.3.<br/>
        /// Example: 98.3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BroadcastMetricCounter(
            int? count,
            double? rate)
        {
            this.Count = count;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastMetricCounter" /> class.
        /// </summary>
        public BroadcastMetricCounter()
        {
        }

    }
}