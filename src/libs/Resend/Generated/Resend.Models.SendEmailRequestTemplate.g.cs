
#nullable enable

namespace Resend
{
    /// <summary>
    /// Use a published template to send the email. If provided, do not include html or text.
    /// </summary>
    public sealed partial class SendEmailRequestTemplate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}