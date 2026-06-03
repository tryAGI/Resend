
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactImportCounts
    {
        /// <summary>
        /// Total number of rows processed by the import.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Number of contacts created by the import.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Number of contacts updated by the import.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public int? Updated { get; set; }

        /// <summary>
        /// Number of rows skipped by the import.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public int? Skipped { get; set; }

        /// <summary>
        /// Number of rows that failed during the import.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImportCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of rows processed by the import.<br/>
        /// Example: 100
        /// </param>
        /// <param name="created">
        /// Number of contacts created by the import.<br/>
        /// Example: 80
        /// </param>
        /// <param name="updated">
        /// Number of contacts updated by the import.<br/>
        /// Example: 10
        /// </param>
        /// <param name="skipped">
        /// Number of rows skipped by the import.<br/>
        /// Example: 5
        /// </param>
        /// <param name="failed">
        /// Number of rows that failed during the import.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactImportCounts(
            int? total,
            int? created,
            int? updated,
            int? skipped,
            int? failed)
        {
            this.Total = total;
            this.Created = created;
            this.Updated = updated;
            this.Skipped = skipped;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImportCounts" /> class.
        /// </summary>
        public ContactImportCounts()
        {
        }

    }
}