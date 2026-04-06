
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEventResponse
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: event
        /// </summary>
        /// <example>event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the updated event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: event
        /// </param>
        /// <param name="id">
        /// The ID of the updated event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEventResponse(
            string? @object,
            global::System.Guid? id)
        {
            this.Object = @object;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventResponse" /> class.
        /// </summary>
        public UpdateEventResponse()
        {
        }
    }
}