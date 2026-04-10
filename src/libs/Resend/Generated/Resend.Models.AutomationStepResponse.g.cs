
#nullable enable

namespace Resend
{
    /// <summary>
    /// A step as returned when retrieving an automation.
    /// </summary>
    public sealed partial class AutomationStepResponse
    {
        /// <summary>
        /// The unique key of this step within the automation graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The type of automation step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationStepResponseTypeJsonConverter))]
        public global::Resend.AutomationStepResponseType? Type { get; set; }

        /// <summary>
        /// Configuration for the step. Shape depends on `type`. For `delay` steps, config contains `{ duration: string }` with a human-readable duration (e.g. `"30 minutes"`). For `wait_for_event` steps, config contains `{ event_name: string, timeout?: string, filter_rule?: object }` where `timeout` is a human-readable duration.
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
        /// <param name="key">
        /// The unique key of this step within the automation graph.
        /// </param>
        /// <param name="type">
        /// The type of automation step.
        /// </param>
        /// <param name="config">
        /// Configuration for the step. Shape depends on `type`. For `delay` steps, config contains `{ duration: string }` with a human-readable duration (e.g. `"30 minutes"`). For `wait_for_event` steps, config contains `{ event_name: string, timeout?: string, filter_rule?: object }` where `timeout` is a human-readable duration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationStepResponse(
            string? key,
            global::Resend.AutomationStepResponseType? type,
            object? config)
        {
            this.Key = key;
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