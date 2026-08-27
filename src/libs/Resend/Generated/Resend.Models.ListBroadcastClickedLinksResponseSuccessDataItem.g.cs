
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListBroadcastClickedLinksResponseSuccessDataItem
    {
        /// <summary>
        /// An opaque cursor for this row, used only for pagination. It does not identify any entity in Resend.<br/>
        /// Example: b2Zmc2V0OjA
        /// </summary>
        /// <example>b2Zmc2V0OjA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL that was clicked.<br/>
        /// Example: https://resend.com/pricing
        /// </summary>
        /// <example>https://resend.com/pricing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Total number of clicks on this URL.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clicks")]
        public int? Clicks { get; set; }

        /// <summary>
        /// Number of unique clicks on this URL.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_clicks")]
        public int? UniqueClicks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastClickedLinksResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// An opaque cursor for this row, used only for pagination. It does not identify any entity in Resend.<br/>
        /// Example: b2Zmc2V0OjA
        /// </param>
        /// <param name="url">
        /// The URL that was clicked.<br/>
        /// Example: https://resend.com/pricing
        /// </param>
        /// <param name="clicks">
        /// Total number of clicks on this URL.<br/>
        /// Example: 42
        /// </param>
        /// <param name="uniqueClicks">
        /// Number of unique clicks on this URL.<br/>
        /// Example: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBroadcastClickedLinksResponseSuccessDataItem(
            string? id,
            string? url,
            int? clicks,
            int? uniqueClicks)
        {
            this.Id = id;
            this.Url = url;
            this.Clicks = clicks;
            this.UniqueClicks = uniqueClicks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastClickedLinksResponseSuccessDataItem" /> class.
        /// </summary>
        public ListBroadcastClickedLinksResponseSuccessDataItem()
        {
        }

    }
}