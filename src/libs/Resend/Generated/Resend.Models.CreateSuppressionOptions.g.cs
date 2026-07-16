
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSuppressionOptions
    {
        /// <summary>
        /// Email address to suppress.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </summary>
        /// <example>steve.wozniak@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSuppressionOptions" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address to suppress.<br/>
        /// Example: steve.wozniak@gmail.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSuppressionOptions(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSuppressionOptions" /> class.
        /// </summary>
        public CreateSuppressionOptions()
        {
        }

    }
}