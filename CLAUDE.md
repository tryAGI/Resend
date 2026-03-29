# CLAUDE.md -- Resend SDK

## Overview

Auto-generated C# SDK for [Resend](https://resend.com/) -- developer email API with emails, contacts, domains, templates, broadcasts, webhooks, and more.
OpenAPI spec from `https://raw.githubusercontent.com/resend/resend-openapi/main/resend.yaml`.

## Build & Test

```bash
dotnet build Resend.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

HTTP Bearer token. API key from Resend dashboard:

```csharp
var client = new ResendClient(apiKey); // RESEND_API_KEY env var
```

## Key Files

- `src/libs/Resend/openapi.yaml` -- OpenAPI spec
- `src/libs/Resend/generate.sh` -- Regeneration script
- `src/libs/Resend/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Resend/Extensions/ResendClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new ResendClient(apiKey);

// Emails -- send, list, get, cancel, batch
client.Emails.CreateEmailsAsync(...)         // Send email
client.Emails.GetEmailsAsync()               // List emails
client.Emails.GetEmailsByEmailIdAsync(id)    // Get email by ID
client.Emails.CreateEmailsBatchAsync(...)    // Send batch emails
client.Emails.CreateEmailsByEmailIdCancelAsync(id) // Cancel scheduled email

// Domains -- create, list, get, verify, delete
client.Domains.CreateDomainsAsync(...)       // Create domain
client.Domains.GetDomainsAsync()             // List domains
client.Domains.GetDomainsByDomainIdAsync(id) // Get domain
client.Domains.CreateDomainsByDomainIdVerifyAsync(id) // Verify domain

// Contacts -- create, list, get, update, delete
client.Contacts.CreateContactsAsync(...)     // Create contact
client.Contacts.GetContactsAsync()           // List contacts
client.Contacts.GetContactsByIdAsync(id)     // Get contact

// Templates -- create, list, get, update, delete, publish
client.Templates.CreateTemplatesAsync(...)   // Create template
client.Templates.GetTemplatesAsync()         // List templates

// Broadcasts -- create, list, get, send
client.Broadcasts.CreateBroadcastsAsync(...) // Create broadcast
client.Broadcasts.CreateBroadcastsByIdSendAsync(id, ...) // Send broadcast

// Webhooks -- create, list, get, update, delete
client.Webhooks.CreateWebhooksAsync(...)     // Create webhook
client.Webhooks.GetWebhooksAsync()           // List webhooks
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsSendEmailTool()` -- Send an email with from, to, subject, and body
- `AsGetEmailTool()` -- Get status and details of a sent email by ID
- `AsListEmailsTool()` -- List sent emails
- `AsListDomainsTool()` -- List all domains
- `AsListContactsTool()` -- List all contacts
- `AsListTemplatesTool()` -- List all email templates
