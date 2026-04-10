
#nullable enable

namespace Resend
{
    /// <summary>
    /// Configuration for the step. Shape depends on `type`. For `delay` steps, config contains `{ duration: string }` with a human-readable duration (e.g. `"30 minutes"`). For `wait_for_event` steps, config contains `{ event_name: string, timeout?: string, filter_rule?: object }` where `timeout` is a human-readable duration.
    /// </summary>
    public sealed partial class AutomationStepResponseConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}