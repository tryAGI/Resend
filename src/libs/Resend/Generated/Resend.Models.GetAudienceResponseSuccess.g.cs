
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetAudienceResponseSuccess
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
        /// The name of the audience.<br/>
        /// Example: Registered Users
        /// </summary>
        /// <example>Registered Users</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Name { get; set; }

        /// <summary>
        /// The date that the object was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </summary>
        /// <example>2023-10-06T22:59:55.977Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudienceResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the audience.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="object">
        /// The object of the audience.<br/>
        /// Example: audience
        /// </param>
        /// <param name="name">
        /// The name of the audience.<br/>
        /// Example: Registered Users
        /// </param>
        /// <param name="createdAt">
        /// The date that the object was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAudienceResponseSuccess(
            string? id,
            string? @object,
            string? name,
            string? createdAt)
        {
            this.Id = id;
            this.Object = @object;
            this.Name = name;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudienceResponseSuccess" /> class.
        /// </summary>
        public GetAudienceResponseSuccess()
        {
        }
    }
}