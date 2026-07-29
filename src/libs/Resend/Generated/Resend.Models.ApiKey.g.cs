
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// The ID of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date and time the API key was created.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the API key was last used.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </summary>
        /// <example>2023-10-06 23:47:56.678+00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public string? LastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the API key.
        /// </param>
        /// <param name="name">
        /// The name of the API key.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the API key was created.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
        /// <param name="lastUsedAt">
        /// The date and time the API key was last used.<br/>
        /// Example: 2023-10-06 23:47:56.678+00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            string? id,
            string? name,
            string? createdAt,
            string? lastUsedAt)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }

    }
}