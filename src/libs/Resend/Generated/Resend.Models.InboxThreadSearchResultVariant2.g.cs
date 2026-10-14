
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxThreadSearchResultVariant2
    {
        /// <summary>
        /// Identifies the email in the thread that matched the search. When `query` has words or phrases, it is the most relevant match. Otherwise, it is the newest. The get, reply and forward thread email endpoints accept it as `email_id`, but it is not equal to the `id` those endpoints return. Null when the search index returns no matched email for the thread.<br/>
        /// Example: e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80
        /// </summary>
        /// <example>e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_email_id")]
        public global::System.Guid? MatchedEmailId { get; set; }

        /// <summary>
        /// Where `query` matched the email in `matched_email_id`, as text fragments with each match wrapped in `**`. Only keys with a match are present. An empty object when there is no `query`.<br/>
        /// Example: {"subject":["September **invoice**"],"attachments":["**invoice**-2026-09.pdf"]}
        /// </summary>
        /// <example>{"subject":["September **invoice**"],"attachments":["**invoice**-2026-09.pdf"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxThreadSearchResultVariant2Highlights Highlights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2" /> class.
        /// </summary>
        /// <param name="highlights">
        /// Where `query` matched the email in `matched_email_id`, as text fragments with each match wrapped in `**`. Only keys with a match are present. An empty object when there is no `query`.<br/>
        /// Example: {"subject":["September **invoice**"],"attachments":["**invoice**-2026-09.pdf"]}
        /// </param>
        /// <param name="matchedEmailId">
        /// Identifies the email in the thread that matched the search. When `query` has words or phrases, it is the most relevant match. Otherwise, it is the newest. The get, reply and forward thread email endpoints accept it as `email_id`, but it is not equal to the `id` those endpoints return. Null when the search index returns no matched email for the thread.<br/>
        /// Example: e8a3f1c6-2b9d-4e5a-a7c4-9d1b6f3e2a80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadSearchResultVariant2(
            global::Resend.InboxThreadSearchResultVariant2Highlights highlights,
            global::System.Guid? matchedEmailId)
        {
            this.MatchedEmailId = matchedEmailId;
            this.Highlights = highlights ?? throw new global::System.ArgumentNullException(nameof(highlights));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2" /> class.
        /// </summary>
        public InboxThreadSearchResultVariant2()
        {
        }

    }
}