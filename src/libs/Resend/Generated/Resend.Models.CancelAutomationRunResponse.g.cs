
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelAutomationRunResponse
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: automation_run
        /// </summary>
        /// <example>automation_run</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the cancelled automation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the automation run after cancelling.<br/>
        /// Example: cancelled
        /// </summary>
        /// <example>cancelled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAutomationRunResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: automation_run
        /// </param>
        /// <param name="id">
        /// The ID of the cancelled automation run.
        /// </param>
        /// <param name="status">
        /// The status of the automation run after cancelling.<br/>
        /// Example: cancelled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelAutomationRunResponse(
            string? @object,
            string? id,
            string? status)
        {
            this.Object = @object;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAutomationRunResponse" /> class.
        /// </summary>
        public CancelAutomationRunResponse()
        {
        }

    }
}