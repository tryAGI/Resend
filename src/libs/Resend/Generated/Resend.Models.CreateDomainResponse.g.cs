
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDomainResponse
    {
        /// <summary>
        /// The ID of the domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date and time the domain was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The status of the domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Resend.DomainCapabilities? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Records { get; set; }

        /// <summary>
        /// The region where the domain is hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the domain.
        /// </param>
        /// <param name="name">
        /// The name of the domain.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the domain was created.
        /// </param>
        /// <param name="status">
        /// The status of the domain.
        /// </param>
        /// <param name="capabilities">
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </param>
        /// <param name="records"></param>
        /// <param name="region">
        /// The region where the domain is hosted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDomainResponse(
            string? id,
            string? name,
            global::System.DateTime? createdAt,
            string? status,
            global::Resend.DomainCapabilities? capabilities,
            global::System.Collections.Generic.IList<global::Resend.DomainRecord>? records,
            string? region)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Capabilities = capabilities;
            this.Records = records;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainResponse" /> class.
        /// </summary>
        public CreateDomainResponse()
        {
        }
    }
}