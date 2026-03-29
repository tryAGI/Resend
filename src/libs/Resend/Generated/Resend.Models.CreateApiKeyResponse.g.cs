
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyResponse
    {
        /// <summary>
        /// The ID of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The token of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the API key.
        /// </param>
        /// <param name="token">
        /// The token of the API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyResponse(
            string? id,
            string? token)
        {
            this.Id = id;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        public CreateApiKeyResponse()
        {
        }
    }
}