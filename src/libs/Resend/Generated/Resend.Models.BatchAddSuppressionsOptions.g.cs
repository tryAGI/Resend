
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchAddSuppressionsOptions
    {
        /// <summary>
        /// Email addresses to suppress.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </summary>
        /// <example>[steve.wozniak@gmail.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddSuppressionsOptions" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to suppress.<br/>
        /// Example: [steve.wozniak@gmail.com]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchAddSuppressionsOptions(
            global::System.Collections.Generic.IList<string> emails)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddSuppressionsOptions" /> class.
        /// </summary>
        public BatchAddSuppressionsOptions()
        {
        }

    }
}