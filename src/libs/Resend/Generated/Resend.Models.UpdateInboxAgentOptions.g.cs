
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `instructions`, `tone`, or `actions` must be provided. Omitted fields keep their current value.
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
        /// The tone the agent writes in. Send null to clear the tone.<br/>
        /// Example: concise_professional
        /// </summary>
        /// <example>concise_professional</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateInboxAgentOptionsToneJsonConverter))]
        public global::Resend.UpdateInboxAgentOptionsTone? Tone { get; set; }

        /// <summary>
        /// The actions the agent can take. Replaces the whole set. Duplicates are removed. Send an empty array to disable all actions. The old names `archive_thread` and `delete_thread` return a 422. Use `archive` and `move_to_trash`.<br/>
        /// Example: [draft_reply, add_labels]
        /// </summary>
        /// <example>[draft_reply, add_labels]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsAction>? Actions { get; set; }

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
        /// The tone the agent writes in. Send null to clear the tone.<br/>
        /// Example: concise_professional
        /// </param>
        /// <param name="actions">
        /// The actions the agent can take. Replaces the whole set. Duplicates are removed. Send an empty array to disable all actions. The old names `archive_thread` and `delete_thread` return a 422. Use `archive` and `move_to_trash`.<br/>
        /// Example: [draft_reply, add_labels]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxAgentOptions(
            string? instructions,
            global::Resend.UpdateInboxAgentOptionsTone? tone,
            global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsAction>? actions)
        {
            this.Instructions = instructions;
            this.Tone = tone;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxAgentOptions" /> class.
        /// </summary>
        public UpdateInboxAgentOptions()
        {
        }

    }
}