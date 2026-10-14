
#nullable enable

namespace Resend
{
    /// <summary>
    /// A thread as it appears in the list of an inbox's threads.
    /// </summary>
    public sealed partial class InboxThread
    {
        /// <summary>
        /// The ID of the thread.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </summary>
        /// <example>4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The subject of the thread.<br/>
        /// Example: Refund for order 1041
        /// </summary>
        /// <example>Refund for order 1041</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The sender email address. Can include the display name.<br/>
        /// Example: ada@example.org
        /// </summary>
        /// <example>ada@example.org</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The recipients of the most recent email. For a received email, these are the addresses it was delivered to, not the full `To` header.<br/>
        /// Example: [support@example.com]
        /// </summary>
        /// <example>[support@example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> To { get; set; }

        /// <summary>
        /// The CC recipients of the most recent email.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cc { get; set; }

        /// <summary>
        /// The BCC recipients of the most recent email. Always empty for a received email.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bcc { get; set; }

        /// <summary>
        /// The labels attached to the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> Labels { get; set; }

        /// <summary>
        /// The number of emails in the thread.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmailCount { get; set; }

        /// <summary>
        /// Whether the most recent email in the thread has an attachment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_attachment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAttachment { get; set; }

        /// <summary>
        /// Whether the thread has an unsent draft.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDraft { get; set; }

        /// <summary>
        /// True only when every email in the thread is read.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Timestamp when the thread was last active.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </summary>
        /// <example>2026-08-05T14:03:11.229Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReceivedAt { get; set; }

        /// <summary>
        /// The folder the thread is in. Every thread is in exactly one folder. `inbox` holds threads with at least one received email. `archive` and `spam` hold threads moved there. `trash` holds threads scheduled for deletion in 30 days. `sent` holds threads whose emails are all outbound, and is assigned automatically.<br/>
        /// Example: inbox
        /// </summary>
        /// <example>inbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.InboxThreadFolderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Resend.InboxThreadFolder Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThread" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the thread.<br/>
        /// Example: 4d8e2a1c-9b3f-4c6d-8a21-3e5f7c9c0d12
        /// </param>
        /// <param name="to">
        /// The recipients of the most recent email. For a received email, these are the addresses it was delivered to, not the full `To` header.<br/>
        /// Example: [support@example.com]
        /// </param>
        /// <param name="cc">
        /// The CC recipients of the most recent email.<br/>
        /// Example: []
        /// </param>
        /// <param name="bcc">
        /// The BCC recipients of the most recent email. Always empty for a received email.<br/>
        /// Example: []
        /// </param>
        /// <param name="labels">
        /// The labels attached to the thread.
        /// </param>
        /// <param name="emailCount">
        /// The number of emails in the thread.<br/>
        /// Example: 2
        /// </param>
        /// <param name="hasAttachment">
        /// Whether the most recent email in the thread has an attachment.<br/>
        /// Example: true
        /// </param>
        /// <param name="hasDraft">
        /// Whether the thread has an unsent draft.<br/>
        /// Example: false
        /// </param>
        /// <param name="read">
        /// True only when every email in the thread is read.<br/>
        /// Example: false
        /// </param>
        /// <param name="receivedAt">
        /// Timestamp when the thread was last active.<br/>
        /// Example: 2026-08-05T14:03:11.229Z
        /// </param>
        /// <param name="folder">
        /// The folder the thread is in. Every thread is in exactly one folder. `inbox` holds threads with at least one received email. `archive` and `spam` hold threads moved there. `trash` holds threads scheduled for deletion in 30 days. `sent` holds threads whose emails are all outbound, and is assigned automatically.<br/>
        /// Example: inbox
        /// </param>
        /// <param name="subject">
        /// The subject of the thread.<br/>
        /// Example: Refund for order 1041
        /// </param>
        /// <param name="from">
        /// The sender email address. Can include the display name.<br/>
        /// Example: ada@example.org
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboxThread(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> to,
            global::System.Collections.Generic.IList<string> cc,
            global::System.Collections.Generic.IList<string> bcc,
            global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel> labels,
            int emailCount,
            bool hasAttachment,
            bool hasDraft,
            bool read,
            global::System.DateTime receivedAt,
            global::Resend.InboxThreadFolder folder,
            string? subject,
            string? from)
        {
            this.Id = id;
            this.Subject = subject;
            this.From = from;
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Cc = cc ?? throw new global::System.ArgumentNullException(nameof(cc));
            this.Bcc = bcc ?? throw new global::System.ArgumentNullException(nameof(bcc));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.EmailCount = emailCount;
            this.HasAttachment = hasAttachment;
            this.HasDraft = hasDraft;
            this.Read = read;
            this.ReceivedAt = receivedAt;
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboxThread" /> class.
        /// </summary>
        public InboxThread()
        {
        }

    }
}