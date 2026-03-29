
#nullable enable

namespace Resend
{
    /// <summary>
    /// The email headers.<br/>
    /// Example: {"X-Custom-Header":"value"}
    /// </summary>
    public sealed partial class GetReceivedEmailResponseHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}