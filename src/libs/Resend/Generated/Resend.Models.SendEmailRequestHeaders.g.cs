
#nullable enable

namespace Resend
{
    /// <summary>
    /// Custom headers to add to the email.
    /// </summary>
    public sealed partial class SendEmailRequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}