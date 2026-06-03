
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactImport
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: contact_import
        /// </summary>
        /// <example>contact_import</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unique identifier for the contact import.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </summary>
        /// <example>479e3145-dd38-476b-932c-529ceb705947</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Current status of the contact import.<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.ContactImportStatusJsonConverter))]
        public global::Resend.ContactImportStatus? Status { get; set; }

        /// <summary>
        /// Timestamp indicating when the contact import was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:47:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the contact import completed.<br/>
        /// Example: 2023-10-06T23:50:56.678Z
        /// </summary>
        /// <example>2023-10-06T23:50:56.678Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        public global::Resend.ContactImportCounts? Counts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImport" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: contact_import
        /// </param>
        /// <param name="id">
        /// Unique identifier for the contact import.<br/>
        /// Example: 479e3145-dd38-476b-932c-529ceb705947
        /// </param>
        /// <param name="status">
        /// Current status of the contact import.<br/>
        /// Example: completed
        /// </param>
        /// <param name="createdAt">
        /// Timestamp indicating when the contact import was created.<br/>
        /// Example: 2023-10-06T23:47:56.678Z
        /// </param>
        /// <param name="completedAt">
        /// Timestamp indicating when the contact import completed.<br/>
        /// Example: 2023-10-06T23:50:56.678Z
        /// </param>
        /// <param name="counts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactImport(
            string? @object,
            global::System.Guid? id,
            global::Resend.ContactImportStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            global::Resend.ContactImportCounts? counts)
        {
            this.Object = @object;
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Counts = counts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImport" /> class.
        /// </summary>
        public ContactImport()
        {
        }

    }
}