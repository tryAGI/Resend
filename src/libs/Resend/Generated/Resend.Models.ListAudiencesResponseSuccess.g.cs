
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ListAudiencesResponseSuccess
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Object { get; set; }

        /// <summary>
        /// Array containing audience information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudiencesResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: list
        /// </param>
        /// <param name="data">
        /// Array containing audience information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAudiencesResponseSuccess(
            string? @object,
            global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudiencesResponseSuccess" /> class.
        /// </summary>
        public ListAudiencesResponseSuccess()
        {
        }
    }
}