
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListBroadcastRecipientsResponseSuccessDataItem
    {
        /// <summary>
        /// Opaque cursor identifying this row, used for pagination.<br/>
        /// Example: b2Zmc2V0OjA
        /// </summary>
        /// <example>b2Zmc2V0OjA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the contact associated with this recipient, if one exists.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </summary>
        /// <example>e169aa45-1ecf-4183-9955-b1499d5701d3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public string? ContactId { get; set; }

        /// <summary>
        /// The recipient's email address.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </summary>
        /// <example>steve.wozniak@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The number of times this recipient triggered the event. Only present when `type` is `opened` or `clicked`.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// The type of bounce. Only present when `type` is `bounced`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounce_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ListBroadcastRecipientsResponseSuccessDataItemBounceTypeJsonConverter))]
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType? BounceType { get; set; }

        /// <summary>
        /// The links this recipient clicked. Only present when `type` is `clicked`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clicked_links")]
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? ClickedLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastRecipientsResponseSuccessDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque cursor identifying this row, used for pagination.<br/>
        /// Example: b2Zmc2V0OjA
        /// </param>
        /// <param name="contactId">
        /// The ID of the contact associated with this recipient, if one exists.<br/>
        /// Example: e169aa45-1ecf-4183-9955-b1499d5701d3
        /// </param>
        /// <param name="email">
        /// The recipient's email address.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </param>
        /// <param name="count">
        /// The number of times this recipient triggered the event. Only present when `type` is `opened` or `clicked`.<br/>
        /// Example: 3
        /// </param>
        /// <param name="bounceType">
        /// The type of bounce. Only present when `type` is `bounced`.
        /// </param>
        /// <param name="clickedLinks">
        /// The links this recipient clicked. Only present when `type` is `clicked`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBroadcastRecipientsResponseSuccessDataItem(
            string? id,
            string? contactId,
            string? email,
            int? count,
            global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType? bounceType,
            global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? clickedLinks)
        {
            this.Id = id;
            this.ContactId = contactId;
            this.Email = email;
            this.Count = count;
            this.BounceType = bounceType;
            this.ClickedLinks = clickedLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBroadcastRecipientsResponseSuccessDataItem" /> class.
        /// </summary>
        public ListBroadcastRecipientsResponseSuccessDataItem()
        {
        }

    }
}