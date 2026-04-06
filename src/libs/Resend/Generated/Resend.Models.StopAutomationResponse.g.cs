
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopAutomationResponse
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: automation
        /// </summary>
        /// <example>automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the stopped automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the automation after stopping.<br/>
        /// Example: disabled
        /// </summary>
        /// <example>disabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopAutomationResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: automation
        /// </param>
        /// <param name="id">
        /// The ID of the stopped automation.
        /// </param>
        /// <param name="status">
        /// The status of the automation after stopping.<br/>
        /// Example: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopAutomationResponse(
            string? @object,
            string? id,
            string? status)
        {
            this.Object = @object;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopAutomationResponse" /> class.
        /// </summary>
        public StopAutomationResponse()
        {
        }
    }
}