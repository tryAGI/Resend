
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VerifyDomainOptions
    {
        /// <summary>
        /// Limit the check to specific records. The only supported value is `forge`: only the Forge record is checked, and the other records keep their current status. Requires Forge to be enabled on the domain, otherwise the endpoint responds with a `forge_not_enabled` error. When omitted, all records are checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::Resend.VerifyDomainOptionsScopeItem>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyDomainOptions" /> class.
        /// </summary>
        /// <param name="scope">
        /// Limit the check to specific records. The only supported value is `forge`: only the Forge record is checked, and the other records keep their current status. Requires Forge to be enabled on the domain, otherwise the endpoint responds with a `forge_not_enabled` error. When omitted, all records are checked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyDomainOptions(
            global::System.Collections.Generic.IList<global::Resend.VerifyDomainOptionsScopeItem>? scope)
        {
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyDomainOptions" /> class.
        /// </summary>
        public VerifyDomainOptions()
        {
        }

    }
}