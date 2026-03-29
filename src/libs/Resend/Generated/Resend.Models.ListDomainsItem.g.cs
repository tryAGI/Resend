
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDomainsItem
    {
        /// <summary>
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the domain.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the domain.<br/>
        /// Example: not_started
        /// </summary>
        /// <example>not_started</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The date and time the domain was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </summary>
        /// <example>2023-04-26T20:21:26.347412+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The region where the domain is hosted.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Resend.DomainCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDomainsItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="name">
        /// The name of the domain.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="status">
        /// The status of the domain.<br/>
        /// Example: not_started
        /// </param>
        /// <param name="createdAt">
        /// The date and time the domain was created.<br/>
        /// Example: 2023-04-26T20:21:26.347412+00:00
        /// </param>
        /// <param name="region">
        /// The region where the domain is hosted.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="capabilities">
        /// Configure the domain capabilities for sending and receiving emails. At least one capability must be enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDomainsItem(
            string? id,
            string? name,
            string? status,
            global::System.DateTime? createdAt,
            string? region,
            global::Resend.DomainCapabilities? capabilities)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Region = region;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDomainsItem" /> class.
        /// </summary>
        public ListDomainsItem()
        {
        }
    }
}