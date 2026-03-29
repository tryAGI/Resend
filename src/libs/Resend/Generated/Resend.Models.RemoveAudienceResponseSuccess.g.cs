
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class RemoveAudienceResponseSuccess
    {
        /// <summary>
        /// The ID of the audience.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Id { get; set; }

        /// <summary>
        /// The object of the audience.<br/>
        /// Example: audience
        /// </summary>
        /// <example>audience</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Object { get; set; }

        /// <summary>
        /// The deleted attribute indicates that the corresponding audience has been deleted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveAudienceResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the audience.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object of the audience.<br/>
        /// Example: audience
        /// </param>
        /// <param name="deleted">
        /// The deleted attribute indicates that the corresponding audience has been deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveAudienceResponseSuccess(
            string? id,
            string? @object,
            bool? deleted)
        {
            this.Id = id;
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveAudienceResponseSuccess" /> class.
        /// </summary>
        public RemoveAudienceResponseSuccess()
        {
        }
    }
}