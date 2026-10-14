
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `read`, `folder`, `add_label_ids`, or `remove_label_ids` is required. A label ID cannot be both added and removed in the same request.
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
        /// Label IDs to apply to the thread. Between 1 and 10 IDs. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </summary>
        /// <example>[7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_label_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AddLabelIds { get; set; }

        /// <summary>
        /// Label IDs to remove from the thread. Between 1 and 10 IDs. The labels themselves are kept. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [2b6d0f4e-8a1c-4e3b-9d57-1c0e8a6f4b21]
        /// </summary>
        /// <example>[2b6d0f4e-8a1c-4e3b-9d57-1c0e8a6f4b21]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_label_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveLabelIds { get; set; }

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
        /// <param name="addLabelIds">
        /// Label IDs to apply to the thread. Between 1 and 10 IDs. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </param>
        /// <param name="removeLabelIds">
        /// Label IDs to remove from the thread. Between 1 and 10 IDs. The labels themselves are kept. A label ID that does not exist in the inbox returns a 404.<br/>
        /// Example: [2b6d0f4e-8a1c-4e3b-9d57-1c0e8a6f4b21]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboxThreadOptions(
            bool? read,
            global::Resend.UpdateInboxThreadOptionsFolder? folder,
            global::System.Collections.Generic.IList<global::System.Guid>? addLabelIds,
            global::System.Collections.Generic.IList<global::System.Guid>? removeLabelIds)
        {
            this.Read = read;
            this.Folder = folder;
            this.AddLabelIds = addLabelIds;
            this.RemoveLabelIds = removeLabelIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboxThreadOptions" /> class.
        /// </summary>
        public UpdateInboxThreadOptions()
        {
        }

    }
}