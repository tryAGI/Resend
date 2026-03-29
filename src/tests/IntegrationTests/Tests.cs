namespace Resend.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ResendClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RESEND_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RESEND_API_KEY environment variable is not found.");

        var client = new ResendClient(apiKey);
        
        return client;
    }
}
