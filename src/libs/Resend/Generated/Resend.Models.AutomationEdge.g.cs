
#nullable enable

namespace Resend
{
    /// <summary>
    /// An edge connecting two steps in the automation graph.
    /// </summary>
    public sealed partial class AutomationEdge
    {
        /// <summary>
        /// The `ref` of the source step (in requests) or the step ID (in responses).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The `ref` of the target step (in requests) or the step ID (in responses).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// The type of edge. Defaults to `default`.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationEdgeEdgeTypeJsonConverter))]
        public global::Resend.AutomationEdgeEdgeType? EdgeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEdge" /> class.
        /// </summary>
        /// <param name="from">
        /// The `ref` of the source step (in requests) or the step ID (in responses).
        /// </param>
        /// <param name="to">
        /// The `ref` of the target step (in requests) or the step ID (in responses).
        /// </param>
        /// <param name="edgeType">
        /// The type of edge. Defaults to `default`.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationEdge(
            string from,
            string to,
            global::Resend.AutomationEdgeEdgeType? edgeType)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.EdgeType = edgeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEdge" /> class.
        /// </summary>
        public AutomationEdge()
        {
        }
    }
}