
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthGrant
    {
        /// <summary>
        /// The ID of the OAuth grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the OAuth client the grant was issued to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The scopes granted to the OAuth client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// The resource the grant is scoped to, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// The date and time the OAuth grant was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the OAuth grant was revoked, or null if it is still active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// The reason the OAuth grant was revoked, or null if it is still active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_reason")]
        public string? RevokedReason { get; set; }

        /// <summary>
        /// The OAuth client the grant was issued to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::Resend.OAuthGrantClient? Client { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthGrant" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the OAuth grant.
        /// </param>
        /// <param name="clientId">
        /// The ID of the OAuth client the grant was issued to.
        /// </param>
        /// <param name="scopes">
        /// The scopes granted to the OAuth client.
        /// </param>
        /// <param name="resource">
        /// The resource the grant is scoped to, if any.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the OAuth grant was created.
        /// </param>
        /// <param name="revokedAt">
        /// The date and time the OAuth grant was revoked, or null if it is still active.
        /// </param>
        /// <param name="revokedReason">
        /// The reason the OAuth grant was revoked, or null if it is still active.
        /// </param>
        /// <param name="client">
        /// The OAuth client the grant was issued to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthGrant(
            string? id,
            string? clientId,
            global::System.Collections.Generic.IList<string>? scopes,
            string? resource,
            global::System.DateTime? createdAt,
            global::System.DateTime? revokedAt,
            string? revokedReason,
            global::Resend.OAuthGrantClient? client)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Scopes = scopes;
            this.Resource = resource;
            this.CreatedAt = createdAt;
            this.RevokedAt = revokedAt;
            this.RevokedReason = revokedReason;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthGrant" /> class.
        /// </summary>
        public OAuthGrant()
        {
        }

    }
}