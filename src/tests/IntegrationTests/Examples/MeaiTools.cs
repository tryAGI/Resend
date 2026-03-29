/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace Resend.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Resend provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RESEND_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("RESEND_API_KEY environment variable is not found.");

        using var client = new ResendClient(apiKey);

        //// Create tools for email sending, retrieval, domains, contacts, and templates.
        var sendEmailTool = client.AsSendEmailTool();
        var getEmailTool = client.AsGetEmailTool();
        var listEmailsTool = client.AsListEmailsTool();
        var listDomainsTool = client.AsListDomainsTool();
        var listContactsTool = client.AsListContactsTool();
        var listTemplatesTool = client.AsListTemplatesTool();

        Assert.AreEqual("Resend_SendEmail", sendEmailTool.Name);
        Assert.AreEqual("Resend_GetEmail", getEmailTool.Name);
        Assert.AreEqual("Resend_ListEmails", listEmailsTool.Name);
        Assert.AreEqual("Resend_ListDomains", listDomainsTool.Name);
        Assert.AreEqual("Resend_ListContacts", listContactsTool.Name);
        Assert.AreEqual("Resend_ListTemplates", listTemplatesTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { sendEmailTool, getEmailTool, listEmailsTool, listDomainsTool, listContactsTool, listTemplatesTool };
        Assert.AreEqual(6, tools.Length);
    }
}
