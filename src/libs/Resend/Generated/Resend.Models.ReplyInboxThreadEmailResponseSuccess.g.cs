
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplyInboxThreadEmailResponseSuccess
    {
        /// <summary>
        /// The ID of the sent email. Use it with the emails endpoints.<br/>
        /// Example: 6a0c8e58-3d9e-4f7a-8b14-2e3f4a5b6c71
        /// </summary>
        /// <example>6a0c8e58-3d9e-4f7a-8b14-2e3f4a5b6c71</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyInboxThreadEmailResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the sent email. Use it with the emails endpoints.<br/>
        /// Example: 6a0c8e58-3d9e-4f7a-8b14-2e3f4a5b6c71
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyInboxThreadEmailResponseSuccess(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyInboxThreadEmailResponseSuccess" /> class.
        /// </summary>
        public ReplyInboxThreadEmailResponseSuccess()
        {
        }

    }
}