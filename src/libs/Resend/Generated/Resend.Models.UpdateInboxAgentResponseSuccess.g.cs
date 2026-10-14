
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateInboxAgentResponseSuccess
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
        /// The ID of the inbox agent.<br/>
        /// Example: a1f84a4e-6f2b-4f0a-9c1d-8a2e5b3c7d90
        /// </summary>
        /// <example>a1f84a4e-6f2b-4f0a-9c1d-8a2e5b3c7d90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxAgentResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type. Always `inbox_agent`.<br/>
        /// Example: inbox_agent
        /// </param>
        /// <param name="id">
        /// The ID of the inbox agent.<br/>
        /// Example: a1f84a4e-6f2b-4f0a-9c1d-8a2e5b3c7d90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxAgentResponseSuccess(
            string @object,
            global::System.Guid id)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxAgentResponseSuccess" /> class.
        /// </summary>
        public UpdateInboxAgentResponseSuccess()
        {
        }

    }
}