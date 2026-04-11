
#nullable enable

namespace Resend
{
    /// <summary>
    /// Configuration for the step. Shape depends on `type`: - **trigger**: `{ event_name: string }` - **send_email**: `{ template: { id: string, variables?: object }, subject?: string, from?: string, reply_to?: string }` - **delay**: `{ duration: string }` — a human-readable duration (e.g. `"30 minutes"`) - **wait_for_event**: `{ event_name: string, timeout?: string, filter_rule?: object }` — `timeout` is a human-readable duration (e.g. `"1 hour"`) - **condition**: A rule tree with `type` (`rule`, `and`, `or`), `field`, `operator`, and `value` - **contact_update**: `{ first_name?: string|object, last_name?: string|object, unsubscribed?: boolean|object, properties?: object }` - **contact_delete**: `{}` - **add_to_segment**: `{ segment_id: string }`
    /// </summary>
    public sealed partial class AutomationStepConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}