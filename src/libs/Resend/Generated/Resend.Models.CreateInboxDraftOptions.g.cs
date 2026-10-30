
#nullable enable

namespace Resend
{
    /// <summary>
    /// At least one of `to`, `cc`, `bcc`, `subject`, `text`, `html` or `attachments` must be non-empty. The combined recipients of `to`, `cc` and `bcc` cannot exceed 50. `thread_id` and `reply_to_email_id` must be sent together or not at all.
    /// </summary>
    public sealed partial class CreateInboxDraftOptions
    {
        /// <summary>
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name, for example `Ada Lovelace &lt;ada@example.org&gt;`. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </summary>
        /// <example>[ada@example.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? To { get; set; }

        /// <summary>
        /// The CC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Cc { get; set; }

        /// <summary>
        /// The BCC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Bcc { get; set; }

        /// <summary>
        /// The subject. Max 2000 characters. A string that is only whitespace, or that contains a line break, is rejected.<br/>
        /// Example: Refund for order 1041
        /// </summary>
        /// <example>Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Refund issued for order 1041.&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text body.<br/>
        /// Example: Refund issued for order 1041.
        /// </summary>
        /// <example>Refund issued for order 1041.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Files to store on the draft. Each one needs a `filename` and either `content` or a `path` URL. A `path` file is downloaded when the request is made and stored on the draft. When both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft, downloaded ones included, can total at most 25 MB. A `path` that does not start with `http` or `https`, or that cannot be downloaded, returns a 422, and so does a request whose downloads take more than 20 seconds together. An empty file or a blocked file type returns a 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? Attachments { get; set; }

        /// <summary>
        /// The Thread ID to reply in. Must be sent with `reply_to_email_id`.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </summary>
        /// <example>4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// The Email ID to reply to, as returned in `data[].id` by the list thread emails endpoint. Must be sent with `thread_id`.<br/>
        /// Example: 5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60
        /// </summary>
        /// <example>5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to_email_id")]
        public global::System.Guid? ReplyToEmailId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxDraftOptions" /> class.
        /// </summary>
        /// <param name="to">
        /// The recipients. For multiple addresses, send an array of strings. Each value can include a friendly name, for example `Ada Lovelace &lt;ada@example.org&gt;`. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.<br/>
        /// Example: [ada@example.org]
        /// </param>
        /// <param name="cc">
        /// The CC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients. For multiple addresses, send an array of strings. Each address is `email@example.com` or `Name &lt;email@example.com&gt;`. An address that is not valid returns a 422.
        /// </param>
        /// <param name="subject">
        /// The subject. Max 2000 characters. A string that is only whitespace, or that contains a line break, is rejected.<br/>
        /// Example: Refund for order 1041
        /// </param>
        /// <param name="html">
        /// The HTML body.<br/>
        /// Example: &lt;p&gt;Refund issued for order 1041.&lt;/p&gt;
        /// </param>
        /// <param name="text">
        /// The plain text body.<br/>
        /// Example: Refund issued for order 1041.
        /// </param>
        /// <param name="attachments">
        /// Files to store on the draft. Each one needs a `filename` and either `content` or a `path` URL. A `path` file is downloaded when the request is made and stored on the draft. When both are sent, `path` is ignored. A `content_id` returns a 422. The files on a draft, downloaded ones included, can total at most 25 MB. A `path` that does not start with `http` or `https`, or that cannot be downloaded, returns a 422, and so does a request whose downloads take more than 20 seconds together. An empty file or a blocked file type returns a 422.
        /// </param>
        /// <param name="threadId">
        /// The Thread ID to reply in. Must be sent with `reply_to_email_id`.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </param>
        /// <param name="replyToEmailId">
        /// The Email ID to reply to, as returned in `data[].id` by the list thread emails endpoint. Must be sent with `thread_id`.<br/>
        /// Example: 5b1a9f47-2c8d-4e6f-9a03-1d2e3f4a5b60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInboxDraftOptions(
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? to,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc,
            string? subject,
            string? html,
            string? text,
            global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? attachments,
            global::System.Guid? threadId,
            global::System.Guid? replyToEmailId)
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Subject = subject;
            this.Html = html;
            this.Text = text;
            this.Attachments = attachments;
            this.ThreadId = threadId;
            this.ReplyToEmailId = replyToEmailId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxDraftOptions" /> class.
        /// </summary>
        public CreateInboxDraftOptions()
        {
        }

    }
}