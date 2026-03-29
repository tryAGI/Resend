
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: contact
        /// </summary>
        /// <example>contact</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the updated contact.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: contact
        /// </param>
        /// <param name="id">
        /// Unique identifier for the updated contact.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactResponseSuccess(
            string? @object,
            string? id)
        {
            this.Object = @object;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactResponseSuccess" /> class.
        /// </summary>
        public UpdateContactResponseSuccess()
        {
        }
    }
}