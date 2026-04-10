
#nullable enable

namespace Resend
{
    /// <summary>
    /// A step execution within an automation run.
    /// </summary>
    public sealed partial class AutomationRunStep
    {
        /// <summary>
        /// The key of the automation step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The type of automation step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationRunStepTypeJsonConverter))]
        public global::Resend.AutomationRunStepType? Type { get; set; }

        /// <summary>
        /// The execution status of this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The date and time the step started executing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// The date and time the step completed executing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The output produced by the step, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The error produced by the step, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The date and time the step record was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRunStep" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the automation step.
        /// </param>
        /// <param name="type">
        /// The type of automation step.
        /// </param>
        /// <param name="status">
        /// The execution status of this step.
        /// </param>
        /// <param name="startedAt">
        /// The date and time the step started executing.
        /// </param>
        /// <param name="completedAt">
        /// The date and time the step completed executing.
        /// </param>
        /// <param name="output">
        /// The output produced by the step, if any.
        /// </param>
        /// <param name="error">
        /// The error produced by the step, if any.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the step record was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRunStep(
            string? key,
            global::Resend.AutomationRunStepType? type,
            string? status,
            string? startedAt,
            string? completedAt,
            object? output,
            object? error,
            string? createdAt)
        {
            this.Key = key;
            this.Type = type;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Output = output;
            this.Error = error;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRunStep" /> class.
        /// </summary>
        public AutomationRunStep()
        {
        }
    }
}