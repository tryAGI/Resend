
#nullable enable

namespace Resend
{
    /// <summary>
    /// The summary of a single thread.
    /// </summary>
    public sealed partial class InboxThreadSummary
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: inbox_thread
        /// </summary>
        /// <example>inbox_thread</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the thread.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </summary>
        /// <example>4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The subject of the thread.<br/>
        /// Example: Refund for order 1041
        /// </summary>
        /// <example>Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The folder the thread is in.<br/>
        /// Example: inbox
        /// </summary>
        /// <example>inbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxThreadSummaryFolderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxThreadSummaryFolder Folder { get; set; }

        /// <summary>
        /// The labels attached to the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> Labels { get; set; }

        /// <summary>
        /// True only when every email in the thread is read.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSummary" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: inbox_thread
        /// </param>
        /// <param name="id">
        /// The ID of the thread.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </param>
        /// <param name="folder">
        /// The folder the thread is in.<br/>
        /// Example: inbox
        /// </param>
        /// <param name="labels">
        /// The labels attached to the thread.
        /// </param>
        /// <param name="read">
        /// True only when every email in the thread is read.<br/>
        /// Example: false
        /// </param>
        /// <param name="subject">
        /// The subject of the thread.<br/>
        /// Example: Refund for order 1041
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadSummary(
            string @object,
            global::System.Guid id,
            global::Resend.InboxThreadSummaryFolder folder,
            global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> labels,
            bool read,
            string? subject)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Subject = subject;
            this.Folder = folder;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Read = read;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSummary" /> class.
        /// </summary>
        public InboxThreadSummary()
        {
        }

    }
}