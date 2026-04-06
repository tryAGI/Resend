
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendEventResponse
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: event
        /// </summary>
        /// <example>event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The name of the event that was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEventResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: event
        /// </param>
        /// <param name="event">
        /// The name of the event that was sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendEventResponse(
            string? @object,
            string? @event)
        {
            this.Object = @object;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEventResponse" /> class.
        /// </summary>
        public SendEventResponse()
        {
        }
    }
}