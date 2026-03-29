
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDomainResponseSuccess
    {
        /// <summary>
        /// The ID of the updated domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </summary>
        /// <example>d91cd9bd-1176-453e-8fc1-35364d380206</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type representing the updated domain.<br/>
        /// Example: domain
        /// </summary>
        /// <example>domain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the updated domain.<br/>
        /// Example: d91cd9bd-1176-453e-8fc1-35364d380206
        /// </param>
        /// <param name="object">
        /// The object type representing the updated domain.<br/>
        /// Example: domain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDomainResponseSuccess(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainResponseSuccess" /> class.
        /// </summary>
        public UpdateDomainResponseSuccess()
        {
        }
    }
}