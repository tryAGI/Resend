
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `read` or `folder` is required. Use the thread labels endpoints to change labels.
    /// </summary>
    public sealed partial class UpdateInboxThreadOptions
    {
        /// <summary>
        /// Marks every email in the thread read or unread.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Moves the thread to this folder. `sent` is assigned automatically and cannot be set.<br/>
        /// Example: archive
        /// </summary>
        /// <example>archive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.UpdateInboxThreadOptionsFolderJsonConverter))]
        public global::Resend.UpdateInboxThreadOptionsFolder? Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxThreadOptions" /> class.
        /// </summary>
        /// <param name="read">
        /// Marks every email in the thread read or unread.<br/>
        /// Example: true
        /// </param>
        /// <param name="folder">
        /// Moves the thread to this folder. `sent` is assigned automatically and cannot be set.<br/>
        /// Example: archive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxThreadOptions(
            bool? read,
            global::Resend.UpdateInboxThreadOptionsFolder? folder)
        {
            this.Read = read;
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxThreadOptions" /> class.
        /// </summary>
        public UpdateInboxThreadOptions()
        {
        }

    }
}