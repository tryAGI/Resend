
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetInboxThreadLabelsOptions
    {
        /// <summary>
        /// The IDs of the labels the thread carries after the change. Up to 100 IDs, each a label of the inbox. Pass an empty array to take every label off the thread.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </summary>
        /// <example>[7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetInboxThreadLabelsOptions" /> class.
        /// </summary>
        /// <param name="labels">
        /// The IDs of the labels the thread carries after the change. Up to 100 IDs, each a label of the inbox. Pass an empty array to take every label off the thread.<br/>
        /// Example: [7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetInboxThreadLabelsOptions(
            global::System.Collections.Generic.IList<global::System.Guid> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetInboxThreadLabelsOptions" /> class.
        /// </summary>
        public SetInboxThreadLabelsOptions()
        {
        }

    }
}