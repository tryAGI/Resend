
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationListItem
    {
        /// <summary>
        /// The ID of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The current status of the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.AutomationListItemStatusJsonConverter))]
        public global::Resend.AutomationListItemStatus? Status { get; set; }

        /// <summary>
        /// The date and time the automation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the automation was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the automation.
        /// </param>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="status">
        /// The current status of the automation.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the automation was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the automation was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationListItem(
            string? id,
            string? name,
            global::Resend.AutomationListItemStatus? status,
            string? createdAt,
            string? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationListItem" /> class.
        /// </summary>
        public AutomationListItem()
        {
        }
    }
}