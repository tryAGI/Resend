
#nullable enable

namespace Resend
{
    /// <summary>
    /// A connection between two steps in the automation graph.
    /// </summary>
    public sealed partial class AutomationConnection
    {
        /// <summary>
        /// The `key` of the source step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The `key` of the target step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// The type of connection. Defaults to `default`.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationConnectionTypeJsonConverter))]
        public global::Resend.AutomationConnectionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationConnection" /> class.
        /// </summary>
        /// <param name="from">
        /// The `key` of the source step.
        /// </param>
        /// <param name="to">
        /// The `key` of the target step.
        /// </param>
        /// <param name="type">
        /// The type of connection. Defaults to `default`.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationConnection(
            string from,
            string to,
            global::Resend.AutomationConnectionType? type)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationConnection" /> class.
        /// </summary>
        public AutomationConnection()
        {
        }
    }
}