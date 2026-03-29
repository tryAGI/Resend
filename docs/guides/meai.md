# Microsoft.Extensions.AI Integration

The Resend SDK provides `AIFunction` tools that integrate with any `IChatClient` supporting function/tool calling via [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Available Tools

| Tool | Description |
|------|-------------|
| `AsSendEmailTool()` | Send an email with from, to, subject, and body |
| `AsGetEmailTool()` | Get status and details of a sent email by ID |
| `AsListEmailsTool()` | List sent emails |
| `AsListDomainsTool()` | List all verified and pending domains |
| `AsListContactsTool()` | List all contacts |
| `AsListTemplatesTool()` | List all email templates |

## Usage

```csharp
using Resend;
using Microsoft.Extensions.AI;

// Create the Resend client
using var resendClient = new ResendClient(apiKey);

// Create tools
var tools = new[]
{
    resendClient.AsSendEmailTool(),
    resendClient.AsGetEmailTool(),
    resendClient.AsListEmailsTool(),
    resendClient.AsListDomainsTool(),
    resendClient.AsListContactsTool(),
    resendClient.AsListTemplatesTool(),
};

// Use with any IChatClient that supports function calling
var response = await chatClient.GetResponseAsync(
    "Send a welcome email to user@example.com from noreply@mydomain.com",
    new ChatOptions { Tools = tools });
```
