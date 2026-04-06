
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRunListItem
    {
        /// <summary>
        /// The ID of the automation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The current status of the automation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationRunListItemStatusJsonConverter))]
        public global::Resend.AutomationRunListItemStatus? Status { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRunListItem" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRunListItem(
            string? id,
            global::Resend.AutomationRunListItemStatus? status,
            string? startedAt,
            string? completedAt,
            string? createdAt)
        {
            this.Id = id;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRunListItem" /> class.
        /// </summary>
        public AutomationRunListItem()
        {
        }
    }
}