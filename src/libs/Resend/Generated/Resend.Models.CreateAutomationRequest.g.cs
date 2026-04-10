
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAutomationRequest
    {
        /// <summary>
        /// The name of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The initial status of the automation. Defaults to `disabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateAutomationRequestStatusJsonConverter))]
        public global::Resend.CreateAutomationRequestStatus? Status { get; set; }

        /// <summary>
        /// The steps that compose the automation workflow. Must include at least one `trigger` step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.AutomationStep> Steps { get; set; }

        /// <summary>
        /// The connections between steps in the automation graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.AutomationConnection> Connections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="steps">
        /// The steps that compose the automation workflow. Must include at least one `trigger` step.
        /// </param>
        /// <param name="connections">
        /// The connections between steps in the automation graph.
        /// </param>
        /// <param name="status">
        /// The initial status of the automation. Defaults to `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAutomationRequest(
            string name,
            global::System.Collections.Generic.IList<global::Resend.AutomationStep> steps,
            global::System.Collections.Generic.IList<global::Resend.AutomationConnection> connections,
            global::Resend.CreateAutomationRequestStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.Connections = connections ?? throw new global::System.ArgumentNullException(nameof(connections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationRequest" /> class.
        /// </summary>
        public CreateAutomationRequest()
        {
        }
    }
}