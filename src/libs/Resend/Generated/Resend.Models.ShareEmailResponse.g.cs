
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShareEmailResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: email
        /// </summary>
        /// <example>email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </summary>
        /// <example>4ef9a417-02e9-4d39-ad75-9611e0fcc33c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The shareable link, valid until it expires.<br/>
        /// Example: https://resend.com/shared?token=eyJhbGciOiJIUzI1NiJ9...
        /// </summary>
        /// <example>https://resend.com/shared?token=eyJhbGciOiJIUzI1NiJ9...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareEmailResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: email
        /// </param>
        /// <param name="id">
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </param>
        /// <param name="url">
        /// The shareable link, valid until it expires.<br/>
        /// Example: https://resend.com/shared?token=eyJhbGciOiJIUzI1NiJ9...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareEmailResponse(
            string? @object,
            string? id,
            string? url)
        {
            this.Object = @object;
            this.Id = id;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareEmailResponse" /> class.
        /// </summary>
        public ShareEmailResponse()
        {
        }

    }
}