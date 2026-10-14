
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveInboxLabelResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: inbox_label
        /// </summary>
        /// <example>inbox_label</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the removed label.<br/>
        /// Example: 7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34
        /// </summary>
        /// <example>7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Indicates whether the label was deleted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveInboxLabelResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: inbox_label
        /// </param>
        /// <param name="id">
        /// The ID of the removed label.<br/>
        /// Example: 7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the label was deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveInboxLabelResponseSuccess(
            string @object,
            global::System.Guid id,
            bool deleted)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveInboxLabelResponseSuccess" /> class.
        /// </summary>
        public RemoveInboxLabelResponseSuccess()
        {
        }

    }
}