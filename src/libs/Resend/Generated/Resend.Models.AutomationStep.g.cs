
#nullable enable

namespace Resend
{
    /// <summary>
    /// A step in an automation workflow. The `config` object varies based on the step `type`.
    /// </summary>
    public sealed partial class AutomationStep
    {
        /// <summary>
        /// A unique reference identifier for this step within the automation graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// The type of automation step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationStepTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.AutomationStepType Type { get; set; }

        /// <summary>
        /// Configuration for the step. Shape depends on `type`: - **trigger**: `{ event_name: string }` - **send_email**: `{ template_id: string, subject?: string, from?: string, reply_to?: string, variables?: object }` - **delay**: `{ seconds: number }` - **wait_for_event**: `{ event_name: string, timeout_seconds?: number, filter_rule?: object }` - **condition**: A rule tree with `type` (`rule`, `and`, `or`), `field`, `operator`, and `value` - **contact_update**: `{ first_name?: string|object, last_name?: string|object, unsubscribed?: boolean|object, properties?: object }` - **contact_delete**: `{}` - **add_to_segment**: `{ segment_id: string }`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationStep" /> class.
        /// </summary>
        /// <param name="ref">
        /// A unique reference identifier for this step within the automation graph.
        /// </param>
        /// <param name="type">
        /// The type of automation step.
        /// </param>
        /// <param name="config">
        /// Configuration for the step. Shape depends on `type`: - **trigger**: `{ event_name: string }` - **send_email**: `{ template_id: string, subject?: string, from?: string, reply_to?: string, variables?: object }` - **delay**: `{ seconds: number }` - **wait_for_event**: `{ event_name: string, timeout_seconds?: number, filter_rule?: object }` - **condition**: A rule tree with `type` (`rule`, `and`, `or`), `field`, `operator`, and `value` - **contact_update**: `{ first_name?: string|object, last_name?: string|object, unsubscribed?: boolean|object, properties?: object }` - **contact_delete**: `{}` - **add_to_segment**: `{ segment_id: string }`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationStep(
            string @ref,
            global::Resend.AutomationStepType type,
            object config)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationStep" /> class.
        /// </summary>
        public AutomationStep()
        {
        }
    }
}