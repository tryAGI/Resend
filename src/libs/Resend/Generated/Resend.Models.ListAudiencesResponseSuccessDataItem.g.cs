
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAudiencesResponseSuccessDataItem
    {
        /// <summary>
        /// Unique identifier for the audience.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </summary>
        /// <example>78261eea-8f8b-4381-83c6-79fa7120f1cf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the audience.<br/>
        /// Example: Registered Users
        /// </summary>
        /// <example>Registered Users</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp indicating when the audience was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </summary>
        /// <example>2023-10-06T22:59:55.977Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudiencesResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the audience.<br/>
        /// Example: 78261eea-8f8b-4381-83c6-79fa7120f1cf
        /// </param>
        /// <param name="name">
        /// Name of the audience.<br/>
        /// Example: Registered Users
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the audience was created.<br/>
        /// Example: 2023-10-06T22:59:55.977Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAudiencesResponseSuccessDataItem(
            string? id,
            string? name,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudiencesResponseSuccessDataItem" /> class.
        /// </summary>
        public ListAudiencesResponseSuccessDataItem()
        {
        }
    }
}