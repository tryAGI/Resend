
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessContacts
    {
        /// <summary>
        /// Contacts currently stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The plan limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessContacts" /> class.
        /// </summary>
        /// <param name="used">
        /// Contacts currently stored.
        /// </param>
        /// <param name="limit">
        /// The plan limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessContacts(
            int? used,
            int? limit)
        {
            this.Used = used;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessContacts" /> class.
        /// </summary>
        public GetUsageResponseSuccessContacts()
        {
        }

    }
}