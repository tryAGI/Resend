
#nullable enable

namespace Resend
{
    /// <summary>
    /// Where `query` matched the email in `matched_email_id`, as text fragments with each match wrapped in `**`. Only keys with a match are present. An empty object when there is no `query`.<br/>
    /// Example: {"subject":["September **invoice**"],"attachments":["**invoice**-2026-09.pdf"]}
    /// </summary>
    public sealed partial class InboxThreadSearchResultVariant2Highlights
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public global::System.Collections.Generic.IList<string>? Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::System.Collections.Generic.IList<string>? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public global::System.Collections.Generic.IList<string>? From { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.Collections.Generic.IList<string>? To { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public global::System.Collections.Generic.IList<string>? Cc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public global::System.Collections.Generic.IList<string>? Bcc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<string>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2Highlights" /> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="attachments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThreadSearchResultVariant2Highlights(
            global::System.Collections.Generic.IList<string>? subject,
            global::System.Collections.Generic.IList<string>? body,
            global::System.Collections.Generic.IList<string>? from,
            global::System.Collections.Generic.IList<string>? to,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? bcc,
            global::System.Collections.Generic.IList<string>? attachments)
        {
            this.Subject = subject;
            this.Body = body;
            this.From = from;
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThreadSearchResultVariant2Highlights" /> class.
        /// </summary>
        public InboxThreadSearchResultVariant2Highlights()
        {
        }

    }
}