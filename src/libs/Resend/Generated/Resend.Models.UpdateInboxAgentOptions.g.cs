
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `instructions`, `tone`, or `enabled_actions` must be provided. Omitted fields keep their current value.
    /// </summary>
    public sealed partial class UpdateInboxAgentOptions
    {
        /// <summary>
        /// Instructions the agent follows when it handles the threads of the inbox. Max 4000 characters. Leading and trailing whitespace is trimmed, and the trimmed value must not be empty. Send null to clear the instructions.<br/>
        /// Example: Answer refund questions yourself. Escalate legal threats.
        /// </summary>
        /// <example>Answer refund questions yourself. Escalate legal threats.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The tone the agent writes in, such as `friendly and concise`. Max 64 characters. Leading and trailing whitespace is trimmed, and the trimmed value must not be empty. Send null to clear the tone.<br/>
        /// Example: friendly and concise
        /// </summary>
        /// <example>friendly and concise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        public string? Tone { get; set; }

        /// <summary>
        /// The actions the agent can take. Replaces the whole set. Duplicates are removed. Send an empty array to disable all actions.<br/>
        /// Example: [draft_reply, add_labels]
        /// </summary>
        /// <example>[draft_reply, add_labels]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_actions")]
        public global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsEnabledAction>? EnabledActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxAgentOptions" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions the agent follows when it handles the threads of the inbox. Max 4000 characters. Leading and trailing whitespace is trimmed, and the trimmed value must not be empty. Send null to clear the instructions.<br/>
        /// Example: Answer refund questions yourself. Escalate legal threats.
        /// </param>
        /// <param name="tone">
        /// The tone the agent writes in, such as `friendly and concise`. Max 64 characters. Leading and trailing whitespace is trimmed, and the trimmed value must not be empty. Send null to clear the tone.<br/>
        /// Example: friendly and concise
        /// </param>
        /// <param name="enabledActions">
        /// The actions the agent can take. Replaces the whole set. Duplicates are removed. Send an empty array to disable all actions.<br/>
        /// Example: [draft_reply, add_labels]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxAgentOptions(
            string? instructions,
            string? tone,
            global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsEnabledAction>? enabledActions)
        {
            this.Instructions = instructions;
            this.Tone = tone;
            this.EnabledActions = enabledActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxAgentOptions" /> class.
        /// </summary>
        public UpdateInboxAgentOptions()
        {
        }

    }
}