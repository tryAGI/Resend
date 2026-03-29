
#nullable enable

namespace Resend
{
    /// <summary>
    /// Template variables object with key/value pairs.<br/>
    /// Example: {"variableName":"Sign up now","variableName2":123}
    /// </summary>
    public sealed partial class EmailTemplateInputVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}