
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxAgent
    {
        /// <summary>
        /// The object type. Always `inbox_agent`.<br/>
        /// Example: inbox_agent
        /// </summary>
        /// <example>inbox_agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Instructions the agent follows when it handles the threads of the inbox. Null when no instructions are set.<br/>
        /// Example: Answer refund questions yourself. Escalate legal threats.
        /// </summary>
        /// <example>Answer refund questions yourself. Escalate legal threats.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The tone the agent writes in. Null when no tone is set.<br/>
        /// Example: concise_professional
        /// </summary>
        /// <example>concise_professional</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxAgentToneJsonConverter))]
        public global::Resend.InboxAgentTone? Tone { get; set; }

        /// <summary>
        /// The actions the agent can take. Empty when no actions are enabled.<br/>
        /// Example: [draft_reply, add_labels]
        /// </summary>
        /// <example>[draft_reply, add_labels]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxAgentEnabledAction> EnabledActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxAgent" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type. Always `inbox_agent`.<br/>
        /// Example: inbox_agent
        /// </param>
        /// <param name="enabledActions">
        /// The actions the agent can take. Empty when no actions are enabled.<br/>
        /// Example: [draft_reply, add_labels]
        /// </param>
        /// <param name="instructions">
        /// Instructions the agent follows when it handles the threads of the inbox. Null when no instructions are set.<br/>
        /// Example: Answer refund questions yourself. Escalate legal threats.
        /// </param>
        /// <param name="tone">
        /// The tone the agent writes in. Null when no tone is set.<br/>
        /// Example: concise_professional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxAgent(
            string @object,
            global::System.Collections.Generic.IList<global::Resend.InboxAgentEnabledAction> enabledActions,
            string? instructions,
            global::Resend.InboxAgentTone? tone)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Instructions = instructions;
            this.Tone = tone;
            this.EnabledActions = enabledActions ?? throw new global::System.ArgumentNullException(nameof(enabledActions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxAgent" /> class.
        /// </summary>
        public InboxAgent()
        {
        }

    }
}