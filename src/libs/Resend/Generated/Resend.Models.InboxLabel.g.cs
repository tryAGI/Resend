
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxLabel
    {
        /// <summary>
        /// The ID of the label.<br/>
        /// Example: 7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34
        /// </summary>
        /// <example>7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the label.<br/>
        /// Example: Urgent
        /// </summary>
        /// <example>Urgent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The color of the label, as a `#RRGGBB` hex color in uppercase.<br/>
        /// Example: #E93D82
        /// </summary>
        /// <example>#E93D82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Timestamp when the label was created.<br/>
        /// Example: 2026-08-05T14:07:42.881Z
        /// </summary>
        /// <example>2026-08-05T14:07:42.881Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxLabel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the label.<br/>
        /// Example: 7f9c1d2e-4a6b-4c3d-8e15-9b0a7c6d5e34
        /// </param>
        /// <param name="name">
        /// The name of the label.<br/>
        /// Example: Urgent
        /// </param>
        /// <param name="color">
        /// The color of the label, as a `#RRGGBB` hex color in uppercase.<br/>
        /// Example: #E93D82
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the label was created.<br/>
        /// Example: 2026-08-05T14:07:42.881Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxLabel(
            global::System.Guid id,
            string name,
            string color,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxLabel" /> class.
        /// </summary>
        public InboxLabel()
        {
        }

    }
}