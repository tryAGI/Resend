
#nullable enable

namespace Resend
{
    /// <summary>
    /// An optional payload of key/value pairs to include with the event.
    /// </summary>
    public sealed partial class SendEventRequestPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}