#nullable enable

namespace Resend
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create a template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateTemplateResponseSuccess> CreateTemplatesAsync(

            global::Resend.CreateTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a template
        /// </summary>
        /// <param name="name">
        /// The name of the template.
        /// </param>
        /// <param name="alias">
        /// The alias of the template.
        /// </param>
        /// <param name="from">
        /// Sender email address. To include a friendly name, use the format "Your Name &lt;sender@domain.com&gt;".
        /// </param>
        /// <param name="subject">
        /// Email subject.
        /// </param>
        /// <param name="replyTo">
        /// Reply-to email addresses.
        /// </param>
        /// <param name="html">
        /// The HTML version of the template.
        /// </param>
        /// <param name="text">
        /// The plain text version of the template.
        /// </param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateTemplateResponseSuccess> CreateTemplatesAsync(
            string name,
            string html,
            string? alias = default,
            string? from = default,
            string? subject = default,
            global::System.Collections.Generic.IList<string>? replyTo = default,
            string? text = default,
            global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}