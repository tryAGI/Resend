
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveContactResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: contact
        /// </summary>
        /// <example>contact</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the removed contact.<br/>
        /// Example: 520784e2-887d-4c25-b53c-4ad46ad38100
        /// </summary>
        /// <example>520784e2-887d-4c25-b53c-4ad46ad38100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates whether the contact was successfully deleted.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveContactResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: contact
        /// </param>
        /// <param name="id">
        /// Unique identifier for the removed contact.<br/>
        /// Example: 520784e2-887d-4c25-b53c-4ad46ad38100
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the contact was successfully deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveContactResponseSuccess(
            string? @object,
            string? id,
            bool? deleted)
        {
            this.Object = @object;
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactResponseSuccess" /> class.
        /// </summary>
        public RemoveContactResponseSuccess()
        {
        }
    }
}