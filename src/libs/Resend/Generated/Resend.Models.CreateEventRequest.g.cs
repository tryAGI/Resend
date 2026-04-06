
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventRequest
    {
        /// <summary>
        /// The name of the event. Cannot start with the reserved `resend:` prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the event. Cannot start with the reserved `resend:` prefix.
        /// </param>
        /// <param name="schema">
        /// An optional flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEventRequest(
            string name,
            object? schema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        public CreateEventRequest()
        {
        }
    }
}