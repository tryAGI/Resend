
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateInboxDraftResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxDraftResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: inbox_draft
        /// </param>
        /// <param name="id">
        /// The ID of the draft.<br/>
        /// Example: c3a1e8b4-2d5f-4a7c-9e10-6b8d7f5a4c32
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInboxDraftResponseSuccess(
            string @object,
            global::System.Guid id)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxDraftResponseSuccess" /> class.
        /// </summary>
        public CreateInboxDraftResponseSuccess()
        {
        }

    }
}