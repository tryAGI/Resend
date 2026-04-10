
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Automation
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: automation
        /// </summary>
        /// <example>automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The current status of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationStatusJsonConverter))]
        public global::Resend.AutomationStatus? Status { get; set; }

        /// <summary>
        /// The date and time the automation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the automation was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The steps in the active version of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Steps { get; set; }

        /// <summary>
        /// The connections between steps in the active version of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Connections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Automation" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: automation
        /// </param>
        /// <param name="id">
        /// The ID of the automation.
        /// </param>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="status">
        /// The current status of the automation.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the automation was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the automation was last updated.
        /// </param>
        /// <param name="steps">
        /// The steps in the active version of the automation.
        /// </param>
        /// <param name="connections">
        /// The connections between steps in the active version of the automation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Automation(
            string? @object,
            string? id,
            string? name,
            global::Resend.AutomationStatus? status,
            string? createdAt,
            string? updatedAt,
            global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? steps,
            global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? connections)
        {
            this.Object = @object;
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Steps = steps;
            this.Connections = connections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Automation" /> class.
        /// </summary>
        public Automation()
        {
        }
    }
}