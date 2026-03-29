
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendBroadcastResponseSuccess
    {
        /// <summary>
        /// The ID of the broadcast.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendBroadcastResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the broadcast.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendBroadcastResponseSuccess(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendBroadcastResponseSuccess" /> class.
        /// </summary>
        public SendBroadcastResponseSuccess()
        {
        }
    }
}