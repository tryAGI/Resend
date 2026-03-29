
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tag
    {
        /// <summary>
        /// The name of the email tag. It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can contain no more than 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the email tag.It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can contain no more than 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the email tag. It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can contain no more than 256 characters.
        /// </param>
        /// <param name="value">
        /// The value of the email tag.It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can contain no more than 256 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tag(
            string? name,
            string? value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        public Tag()
        {
        }
    }
}