
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// The API key name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The API key can have full access to Resend’s API or be only restricted to send emails. * full_access - Can create, delete, get, and update any resource. * sending_access - Can only send emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.CreateApiKeyRequestPermissionJsonConverter))]
        public global::Resend.CreateApiKeyRequestPermission? Permission { get; set; }

        /// <summary>
        /// Restrict an API key to send emails only from a specific domain. Only used when the permission is sending_access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_id")]
        public string? DomainId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The API key name.
        /// </param>
        /// <param name="permission">
        /// The API key can have full access to Resend’s API or be only restricted to send emails. * full_access - Can create, delete, get, and update any resource. * sending_access - Can only send emails.
        /// </param>
        /// <param name="domainId">
        /// Restrict an API key to send emails only from a specific domain. Only used when the permission is sending_access.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyRequest(
            string name,
            global::Resend.CreateApiKeyRequestPermission? permission,
            string? domainId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permission = permission;
            this.DomainId = domainId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }
    }
}