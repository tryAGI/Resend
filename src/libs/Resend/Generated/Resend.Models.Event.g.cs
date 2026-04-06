
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: event
        /// </summary>
        /// <example>event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The event ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The event name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The date and time the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the event was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: event
        /// </param>
        /// <param name="id">
        /// The event ID.
        /// </param>
        /// <param name="name">
        /// The event name.
        /// </param>
        /// <param name="schema">
        /// A flat key/type map defining the event payload schema. Supported types are `string`, `number`, `boolean`, and `date`.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the event was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the event was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Event(
            string? @object,
            global::System.Guid? id,
            string? name,
            object? schema,
            string? createdAt,
            string? updatedAt)
        {
            this.Object = @object;
            this.Id = id;
            this.Name = name;
            this.Schema = schema;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }
    }
}