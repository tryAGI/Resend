
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Email
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: email
        /// </summary>
        /// <example>email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </summary>
        /// <example>4ef9a417-02e9-4d39-ad75-9611e0fcc33c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: [delivered@resend.dev]
        /// </summary>
        /// <example>[delivered@resend.dev]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public global::System.Collections.Generic.IList<string>? To { get; set; }

        /// <summary>
        /// The email address of the sender.<br/>
        /// Example: Acme &lt;onboarding@resend.dev&gt;
        /// </summary>
        /// <example>Acme &lt;onboarding@resend.dev&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The date and time the email was created.<br/>
        /// Example: 2023-04-03T22:13:42.674981+00:00
        /// </summary>
        /// <example>2023-04-03T22:13:42.674981+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The subject line of the email.<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The HTML body of the email.<br/>
        /// Example: Congrats on sending your &lt;strong&gt;first email&lt;/strong&gt;!
        /// </summary>
        /// <example>Congrats on sending your &lt;strong&gt;first email&lt;/strong&gt;!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The plain text body of the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The email addresses of the blind carbon copy recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public global::System.Collections.Generic.IList<string>? Bcc { get; set; }

        /// <summary>
        /// The email addresses of the carbon copy recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public global::System.Collections.Generic.IList<string>? Cc { get; set; }

        /// <summary>
        /// The email addresses to which replies should be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_to")]
        public global::System.Collections.Generic.IList<string>? ReplyTo { get; set; }

        /// <summary>
        /// The status of the email.<br/>
        /// Example: delivered
        /// </summary>
        /// <example>delivered</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_event")]
        public string? LastEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: email
        /// </param>
        /// <param name="id">
        /// The ID of the email.<br/>
        /// Example: 4ef9a417-02e9-4d39-ad75-9611e0fcc33c
        /// </param>
        /// <param name="to">
        /// Example: [delivered@resend.dev]
        /// </param>
        /// <param name="from">
        /// The email address of the sender.<br/>
        /// Example: Acme &lt;onboarding@resend.dev&gt;
        /// </param>
        /// <param name="createdAt">
        /// The date and time the email was created.<br/>
        /// Example: 2023-04-03T22:13:42.674981+00:00
        /// </param>
        /// <param name="subject">
        /// The subject line of the email.<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="html">
        /// The HTML body of the email.<br/>
        /// Example: Congrats on sending your &lt;strong&gt;first email&lt;/strong&gt;!
        /// </param>
        /// <param name="text">
        /// The plain text body of the email.
        /// </param>
        /// <param name="bcc">
        /// The email addresses of the blind carbon copy recipients.
        /// </param>
        /// <param name="cc">
        /// The email addresses of the carbon copy recipients.
        /// </param>
        /// <param name="replyTo">
        /// The email addresses to which replies should be sent.
        /// </param>
        /// <param name="lastEvent">
        /// The status of the email.<br/>
        /// Example: delivered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Email(
            string? @object,
            string? id,
            global::System.Collections.Generic.IList<string>? to,
            string? from,
            global::System.DateTime? createdAt,
            string? subject,
            string? html,
            string? text,
            global::System.Collections.Generic.IList<string>? bcc,
            global::System.Collections.Generic.IList<string>? cc,
            global::System.Collections.Generic.IList<string>? replyTo,
            string? lastEvent)
        {
            this.Object = @object;
            this.Id = id;
            this.To = to;
            this.From = from;
            this.CreatedAt = createdAt;
            this.Subject = subject;
            this.Html = html;
            this.Text = text;
            this.Bcc = bcc;
            this.Cc = cc;
            this.ReplyTo = replyTo;
            this.LastEvent = lastEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        public Email()
        {
        }
    }
}