
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DuplicateBroadcastResponseSuccess
    {
        /// <summary>
        /// The ID of the duplicated broadcast.<br/>
        /// Example: 1f85ae38-f5b9-4c1f-8766-667a53970fea
        /// </summary>
        /// <example>1f85ae38-f5b9-4c1f-8766-667a53970fea</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type of the response.<br/>
        /// Example: broadcast
        /// </summary>
        /// <example>broadcast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateBroadcastResponseSuccess" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the duplicated broadcast.<br/>
        /// Example: 1f85ae38-f5b9-4c1f-8766-667a53970fea
        /// </param>
        /// <param name="object">
        /// The object type of the response.<br/>
        /// Example: broadcast
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuplicateBroadcastResponseSuccess(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateBroadcastResponseSuccess" /> class.
        /// </summary>
        public DuplicateBroadcastResponseSuccess()
        {
        }

    }
}