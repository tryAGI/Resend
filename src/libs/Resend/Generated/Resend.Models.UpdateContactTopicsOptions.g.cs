
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateContactTopicsOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic> Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsOptions" /> class.
        /// </summary>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactTopicsOptions(
            global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic> topics)
        {
            this.Topics = topics ?? throw new global::System.ArgumentNullException(nameof(topics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTopicsOptions" /> class.
        /// </summary>
        public UpdateContactTopicsOptions()
        {
        }
    }
}