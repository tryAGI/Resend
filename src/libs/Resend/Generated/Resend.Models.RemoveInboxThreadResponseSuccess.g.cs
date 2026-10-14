
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveInboxThreadResponseSuccess
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
        /// True when this call moved the thread to `trash`. False when the thread was already there.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveInboxThreadResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// Example: inbox_thread
        /// </param>
        /// <param name="id">
        /// The ID of the thread.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </param>
        /// <param name="deleted">
        /// True when this call moved the thread to `trash`. False when the thread was already there.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveInboxThreadResponseSuccess(
            string @object,
            global::System.Guid id,
            bool deleted)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveInboxThreadResponseSuccess" /> class.
        /// </summary>
        public RemoveInboxThreadResponseSuccess()
        {
        }

    }
}