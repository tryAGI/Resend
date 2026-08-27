
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShareEmailOptions
    {
        /// <summary>
        /// How long the link stays valid for, as a duration like `10m`, `2 hours`, or `1 day`. Defaults to `48h` and cannot exceed 48 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public string? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareEmailOptions" /> class.
        /// </summary>
        /// <param name="expiresIn">
        /// How long the link stays valid for, as a duration like `10m`, `2 hours`, or `1 day`. Defaults to `48h` and cannot exceed 48 hours.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareEmailOptions(
            string? expiresIn)
        {
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareEmailOptions" /> class.
        /// </summary>
        public ShareEmailOptions()
        {
        }

    }
}