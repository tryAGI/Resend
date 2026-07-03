
#nullable enable

namespace Resend
{
    /// <summary>
    /// The OAuth client the grant was issued to.
    /// </summary>
    public sealed partial class OAuthGrantClient
    {
        /// <summary>
        /// The name of the OAuth client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the OAuth client's logo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthGrantClient" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the OAuth client.
        /// </param>
        /// <param name="logoUri">
        /// The URL of the OAuth client's logo.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthGrantClient(
            string? name,
            string? logoUri)
        {
            this.Name = name;
            this.LogoUri = logoUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthGrantClient" /> class.
        /// </summary>
        public OAuthGrantClient()
        {
        }

    }
}