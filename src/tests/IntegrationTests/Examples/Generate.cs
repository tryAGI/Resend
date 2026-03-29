/* order: 10, title: Email Sending, slug: email-sending */

namespace Resend.IntegrationTests.Examples;

[TestClass]
public class EmailSending
{
    //// Resend provides a developer-friendly email API.
    //// Create a client and send emails, manage contacts, domains, and templates.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RESEND_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("RESEND_API_KEY environment variable is not found.");

        using var client = new ResendClient(apiKey);

        //// The client has sub-clients for different API areas.
        Assert.IsNotNull(client.Emails);
        Assert.IsNotNull(client.Domains);
        Assert.IsNotNull(client.Contacts);
        Assert.IsNotNull(client.Templates);
        Assert.IsNotNull(client.Broadcasts);
        Assert.IsNotNull(client.Webhooks);
    }
}
