
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRun
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: automation_run
        /// </summary>
        /// <example>automation_run</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the automation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The current status of the automation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationRunStatusJsonConverter))]
        public global::Resend.AutomationRunStatus? Status { get; set; }

        /// <summary>
        /// The date and time the run started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// The date and time the run completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The date and time the run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The steps executed in this run, sorted in graph order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRun" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: automation_run
        /// </param>
        /// <param name="id">
        /// The ID of the automation run.
        /// </param>
        /// <param name="status">
        /// The current status of the automation run.
        /// </param>
        /// <param name="startedAt">
        /// The date and time the run started.
        /// </param>
        /// <param name="completedAt">
        /// The date and time the run completed.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the run was created.
        /// </param>
        /// <param name="steps">
        /// The steps executed in this run, sorted in graph order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRun(
            string? @object,
            string? id,
            global::Resend.AutomationRunStatus? status,
            string? startedAt,
            string? completedAt,
            string? createdAt,
            global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? steps)
        {
            this.Object = @object;
            this.Id = id;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRun" /> class.
        /// </summary>
        public AutomationRun()
        {
        }
    }
}