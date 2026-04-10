#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="idempotencyKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendEmailResponse> CreateEmailsAsync(

            global::Resend.SendEmailRequest request,
            string? idempotencyKey = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="idempotencyKey"></param>
        /// <param name="from">
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </param>
        /// <param name="to">
        /// Recipient email address. For multiple addresses, send as an array of strings. Max 50.
        /// </param>
        /// <param name="subject">
        /// Email subject.
        /// </param>
        /// <param name="bcc">
        /// Bcc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="cc">
        /// Cc recipient email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="replyTo">
        /// Reply-to email address. For multiple addresses, send as an array of strings.
        /// </param>
        /// <param name="html">
        /// The HTML version of the message.
        /// </param>
        /// <param name="text">
        /// The plain text version of the message.
        /// </param>
        /// <param name="template"></param>
        /// <param name="headers">
        /// Custom headers to add to the email.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule email to be sent later. The date should be in ISO 8601 format.
        /// </param>
        /// <param name="attachments"></param>
        /// <param name="tags"></param>
        /// <param name="topicId">
        /// The topic ID to scope the email to. If the recipient is a contact and opted-in to the topic, the email is sent. If opted-out, the email is not sent. If the recipient is not a contact, the email is sent if the topic's default subscription is opt_in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.SendEmailResponse> CreateEmailsAsync(
            string from,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>> to,
            string subject,
            string? idempotencyKey = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? bcc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? cc = default,
            global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? replyTo = default,
            string? html = default,
            string? text = default,
            global::Resend.AllOf<global::Resend.EmailTemplateInput, object>? template = default,
            object? headers = default,
            string? scheduledAt = default,
            global::System.Collections.Generic.IList<global::Resend.Attachment>? attachments = default,
            global::System.Collections.Generic.IList<global::Resend.Tag>? tags = default,
            string? topicId = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}