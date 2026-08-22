
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBroadcastRecipientsResponseSuccessDataItemClickedLink
    {
        /// <summary>
        /// The clicked URL.<br/>
        /// Example: https://resend.com/pricing
        /// </summary>
        /// <example>https://resend.com/pricing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The number of times this recipient clicked this URL.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clicks")]
        public int? Clicks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastRecipientsResponseSuccessDataItemClickedLink" /> class.
        /// </summary>
        /// <param name="url">
        /// The clicked URL.<br/>
        /// Example: https://resend.com/pricing
        /// </param>
        /// <param name="clicks">
        /// The number of times this recipient clicked this URL.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBroadcastRecipientsResponseSuccessDataItemClickedLink(
            string? url,
            int? clicks)
        {
            this.Url = url;
            this.Clicks = clicks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastRecipientsResponseSuccessDataItemClickedLink" /> class.
        /// </summary>
        public ListBroadcastRecipientsResponseSuccessDataItemClickedLink()
        {
        }

    }
}