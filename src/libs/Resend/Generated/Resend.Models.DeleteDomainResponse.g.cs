
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDomainResponse
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: domain
        /// </summary>
        /// <example>domain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates whether the domain was deleted successfully.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDomainResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: domain
        /// </param>
        /// <param name="id">
        /// The ID of the domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the domain was deleted successfully.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDomainResponse(
            string? @object,
            string? id,
            bool? deleted)
        {
            this.Object = @object;
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDomainResponse" /> class.
        /// </summary>
        public DeleteDomainResponse()
        {
        }
    }
}