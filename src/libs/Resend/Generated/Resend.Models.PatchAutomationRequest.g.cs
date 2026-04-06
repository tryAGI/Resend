
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `name`, `status`, or `steps` and `edges` must be provided. When updating the workflow graph, both `steps` and `edges` must be provided together.
    /// </summary>
    public sealed partial class PatchAutomationRequest
    {
        /// <summary>
        /// The name of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.PatchAutomationRequestStatusJsonConverter))]
        public global::Resend.PatchAutomationRequestStatus? Status { get; set; }

        /// <summary>
        /// The steps that compose the automation workflow. Must be provided together with `edges`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Steps { get; set; }

        /// <summary>
        /// The edges connecting steps in the automation graph. Must be provided together with `steps`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Resend.AutomationEdge>? Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAutomationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="status">
        /// The status of the automation.
        /// </param>
        /// <param name="steps">
        /// The steps that compose the automation workflow. Must be provided together with `edges`.
        /// </param>
        /// <param name="edges">
        /// The edges connecting steps in the automation graph. Must be provided together with `steps`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAutomationRequest(
            string? name,
            global::Resend.PatchAutomationRequestStatus? status,
            global::System.Collections.Generic.IList<global::Resend.AutomationStep>? steps,
            global::System.Collections.Generic.IList<global::Resend.AutomationEdge>? edges)
        {
            this.Name = name;
            this.Status = status;
            this.Steps = steps;
            this.Edges = edges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAutomationRequest" /> class.
        /// </summary>
        public PatchAutomationRequest()
        {
        }
    }
}