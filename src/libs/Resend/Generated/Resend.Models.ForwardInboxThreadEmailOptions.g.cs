
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ForwardInboxThreadEmailOptions
    {
        /// <summary>
        /// Recipient email address. For multiple addresses, send as an array of strings. Must name at least one address. `to`, `cc` and `bcc` combined cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [colleague@example.org]
        /// </summary>
        /// <example>[colleague@example.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> To { get; set; }

        /// <summary>
        /// CC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </summary>
        /// <example>[billing@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Cc { get; set; }

        /// <summary>
        /// BCC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </summary>
        /// <example>[records@acme.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Bcc { get; set; }

        /// <summary>
        /// An HTML note sent above the quoted original.<br/>
        /// Example: &lt;p&gt;Flagging this refund request for you.&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Flagging this refund request for you.&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// A plain-text note sent above the quoted original.<br/>
        /// Example: Flagging this refund request for you.
        /// </summary>
        /// <example>Flagging this refund request for you.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The subject of the forward. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Fwd:` if it does not already start with it.<br/>
        /// Example: Fwd: Refund for order 1041
        /// </summary>
        /// <example>Fwd: Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. They share one limit with the attachments of the original message, which the forward also sends. Together they can have up to 10 files and at most 25 MB of `content`. A `path` file counts toward the 10 files only, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that is not an `http` or `https` URL or that points to `localhost`, `127.0.0.1` or `0.0.0.0`, or a `content_type` that is not a valid MIME type returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.Attachment>? Attachments { get; set; }

        /// <summary>
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </summary>
        /// <example>{"X-Ticket-Id":"4821"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardInboxThreadEmailOptions" /> class.
        /// </summary>
        /// <param name="to">
        /// Recipient email address. For multiple addresses, send as an array of strings. Must name at least one address. `to`, `cc` and `bcc` combined cannot exceed 50 recipients. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [colleague@example.org]
        /// </param>
        /// <param name="cc">
        /// CC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [billing@acme.com]
        /// </param>
        /// <param name="bcc">
        /// BCC recipient email address. For multiple addresses, send as an array of strings. Counts toward the 50-recipient limit. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [records@acme.com]
        /// </param>
        /// <param name="html">
        /// An HTML note sent above the quoted original.<br/>
        /// Example: &lt;p&gt;Flagging this refund request for you.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// A plain-text note sent above the quoted original.<br/>
        /// Example: Flagging this refund request for you.
        /// </param>
        /// <param name="subject">
        /// The subject of the forward. Cannot be only whitespace or contain a line break. When omitted, the thread subject is used, prefixed with `Fwd:` if it does not already start with it.<br/>
        /// Example: Fwd: Refund for order 1041
        /// </param>
        /// <param name="attachments">
        /// Files to attach, as on `POST /emails`. Each one needs `content` or `path`. They share one limit with the attachments of the original message, which the forward also sends. Together they can have up to 10 files and at most 25 MB of `content`. A `path` file counts toward the 10 files only, because it is fetched when the email is sent. An empty file, a blocked file type, a `path` that is not an `http` or `https` URL or that points to `localhost`, `127.0.0.1` or `0.0.0.0`, or a `content_type` that is not a valid MIME type returns a 422.
        /// </param>
        /// <param name="headers">
        /// Custom headers to add to the email. The `In-Reply-To`, `References` and `Reply-To` headers are set by Resend and cannot be set here. Sending one of them, in any letter case, returns a 422. Header names cannot be empty, and names and values cannot contain line breaks or null characters, or the request returns a 422. `null` means no custom headers.<br/>
        /// Example: {"X-Ticket-Id":"4821"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForwardInboxThreadEmailOptions(
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> to,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc,
            string? html,
            string? text,
            string? subject,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Html = html;
            this.Text = text;
            this.Subject = subject;
            this.Attachments = attachments;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardInboxThreadEmailOptions" /> class.
        /// </summary>
        public ForwardInboxThreadEmailOptions()
        {
        }

    }
}