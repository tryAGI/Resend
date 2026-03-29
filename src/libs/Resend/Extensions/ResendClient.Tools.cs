#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Resend;

public static class ResendClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that sends an email via Resend.
    /// </summary>
    public static AIFunction AsSendEmailTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Sender email address, e.g. 'Your Name <sender@domain.com>'")] string from,
                   [Description("Recipient email address(es), comma-separated for multiple")] string to,
                   [Description("Email subject line")] string subject,
                   [Description("HTML body of the email (optional)")] string? html,
                   [Description("Plain text body of the email (optional)")] string? text,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Emails.CreateEmailsAsync(
                    from: from,
                    to: to,
                    subject: subject,
                    html: html,
                    text: text,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                };
            },
            name: "Resend_SendEmail",
            description: "Send an email via the Resend API. Provide sender, recipient, subject, and HTML or plain text body.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves the status and details of a sent email.
    /// </summary>
    public static AIFunction AsGetEmailTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the email to retrieve")] string emailId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Emails.GetEmailsByEmailIdAsync(
                    emailId: emailId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Resend_GetEmail",
            description: "Get the status and details of a sent email by its ID.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists sent emails.
    /// </summary>
    public static AIFunction AsListEmailsTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Emails.GetEmailsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Resend_ListEmails",
            description: "List sent emails from the Resend account.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists domains.
    /// </summary>
    public static AIFunction AsListDomainsTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Domains.GetDomainsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Resend_ListDomains",
            description: "List all verified and pending domains in the Resend account.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists contacts.
    /// </summary>
    public static AIFunction AsListContactsTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Contacts.GetContactsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Resend_ListContacts",
            description: "List all contacts in the Resend account.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists email templates.
    /// </summary>
    public static AIFunction AsListTemplatesTool(this ResendClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Templates.GetTemplatesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Resend_ListTemplates",
            description: "List all email templates in the Resend account.");
    }
}
