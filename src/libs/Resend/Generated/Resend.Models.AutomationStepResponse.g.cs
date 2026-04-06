
#nullable enable

namespace Resend
{
    /// <summary>
    /// A step as returned when retrieving an automation.
    /// </summary>
    public sealed partial class AutomationStepResponse
    {
        /// <summary>
        /// The type of automation step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationStepResponseTypeJsonConverter))]
        public global::Resend.AutomationStepResponseType? Type { get; set; }

        /// <summary>
        /// Configuration for the step. Shape depends on `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationStepResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of automation step.
        /// </param>
        /// <param name="config">
        /// Configuration for the step. Shape depends on `type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationStepResponse(
            global::Resend.AutomationStepResponseType? type,
            object? config)
        {
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationStepResponse" /> class.
        /// </summary>
        public AutomationStepResponse()
        {
        }
    }
}