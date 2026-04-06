
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEventRequest
    {
        /// <summary>
        /// A flat key/type map defining the event payload schema. Set to `null` to clear the schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventRequest" /> class.
        /// </summary>
        /// <param name="schema">
        /// A flat key/type map defining the event payload schema. Set to `null` to clear the schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEventRequest(
            object? schema)
        {
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventRequest" /> class.
        /// </summary>
        public UpdateEventRequest()
        {
        }
    }
}