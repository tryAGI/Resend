
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxThreadSearchResultVariant2
    {
        /// <summary>
        /// The ID of the email in the thread that matched the search. When `query` has words or phrases, it is the most relevant match. Otherwise, it is the newest. It is the same `id` that the list thread emails endpoint returns, so use it as `email_id` with the get, reply and forward endpoints. Null when the search index returns no matched email for the thread.<br/>
        /// Example: e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80
        /// </summary>
        /// <example>e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_email_id")]
        public global::System.Guid? MatchedEmailId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2" /> class.
        /// </summary>
        /// <param name="matchedEmailId">
        /// The ID of the email in the thread that matched the search. When `query` has words or phrases, it is the most relevant match. Otherwise, it is the newest. It is the same `id` that the list thread emails endpoint returns, so use it as `email_id` with the get, reply and forward endpoints. Null when the search index returns no matched email for the thread.<br/>
        /// Example: e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadSearchResultVariant2(
            global::System.Guid? matchedEmailId)
        {
            this.MatchedEmailId = matchedEmailId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2" /> class.
        /// </summary>
        public InboxThreadSearchResultVariant2()
        {
        }

    }
}