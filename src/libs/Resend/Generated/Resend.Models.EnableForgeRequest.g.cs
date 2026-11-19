
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnableForgeRequest
    {
        /// <summary>
        /// The subdomain for the Forge Return-Path address, for example `forge` on `example.com` produces a `CNAME` record for `forge.example.com`. It must start with a letter, end with a letter or digit, and contain only letters, digits, and hyphens, and is stored lowercased. When omitted, Resend picks a subdomain that is free in your DNS. It is set once, when Forge is enabled, and cannot be changed afterwards. It cannot equal the domain's return path on the legacy engine, and the chosen host must not already have DNS records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_return_path")]
        public string? CustomReturnPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableForgeRequest" /> class.
        /// </summary>
        /// <param name="customReturnPath">
        /// The subdomain for the Forge Return-Path address, for example `forge` on `example.com` produces a `CNAME` record for `forge.example.com`. It must start with a letter, end with a letter or digit, and contain only letters, digits, and hyphens, and is stored lowercased. When omitted, Resend picks a subdomain that is free in your DNS. It is set once, when Forge is enabled, and cannot be changed afterwards. It cannot equal the domain's return path on the legacy engine, and the chosen host must not already have DNS records.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnableForgeRequest(
            string? customReturnPath)
        {
            this.CustomReturnPath = customReturnPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableForgeRequest" /> class.
        /// </summary>
        public EnableForgeRequest()
        {
        }

    }
}