
#nullable enable

namespace Resend
{
    /// <summary>
    /// A flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
    /// </summary>
    public sealed partial class EventSummarySchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}