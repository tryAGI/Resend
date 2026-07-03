
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RevokeOAuthGrantResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: oauth_grant
        /// </summary>
        /// <example>oauth_grant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the OAuth grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The date and time the OAuth grant was revoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// The reason the OAuth grant was revoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_reason")]
        public string? RevokedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeOAuthGrantResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: oauth_grant
        /// </param>
        /// <param name="id">
        /// The ID of the OAuth grant.
        /// </param>
        /// <param name="revokedAt">
        /// The date and time the OAuth grant was revoked.
        /// </param>
        /// <param name="revokedReason">
        /// The reason the OAuth grant was revoked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokeOAuthGrantResponse(
            string? @object,
            string? id,
            global::System.DateTime? revokedAt,
            string? revokedReason)
        {
            this.Object = @object;
            this.Id = id;
            this.RevokedAt = revokedAt;
            this.RevokedReason = revokedReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeOAuthGrantResponse" /> class.
        /// </summary>
        public RevokeOAuthGrantResponse()
        {
        }

    }
}