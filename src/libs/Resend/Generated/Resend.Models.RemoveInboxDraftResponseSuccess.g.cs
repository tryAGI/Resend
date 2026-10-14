
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveInboxDraftResponseSuccess
    {
        /// <summary>
        /// The object type.<br/>
        /// Example: inbox_draft
        /// </summary>
        /// <example>inbox_draft</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The ID of the draft.<br/>
        /// Example: c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32
        /// </summary>
        /// <example>c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Indicates whether the draft was successfully deleted.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveInboxDraftResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: inbox_draft
        /// </param>
        /// <param name="id">
        /// The ID of the draft.<br/>
        /// Example: c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the draft was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveInboxDraftResponseSuccess(
            string @object,
            global::System.Guid id,
            bool deleted)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveInboxDraftResponseSuccess" /> class.
        /// </summary>
        public RemoveInboxDraftResponseSuccess()
        {
        }

    }
}