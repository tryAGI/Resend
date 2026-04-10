
#nullable enable

namespace Resend
{
    /// <summary>
    /// Resend is the email platform for developers.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IResendClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Resend.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Create and manage API Keys through the Resend API.
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// Create and manage Automations through the Resend API.
        /// </summary>
        public AutomationsClient Automations { get; }

        /// <summary>
        /// Create and manage Broadcasts through the Resend API.
        /// </summary>
        public BroadcastsClient Broadcasts { get; }

        /// <summary>
        /// Create and manage Contact Properties through the Resend API.
        /// </summary>
        public ContactPropertiesClient ContactProperties { get; }

        /// <summary>
        /// Create and manage Contacts through the Resend API.
        /// </summary>
        public ContactsClient Contacts { get; }

        /// <summary>
        /// Create and manage domains through the Resend API.
        /// </summary>
        public DomainsClient Domains { get; }

        /// <summary>
        /// Start sending emails through the Resend API.
        /// </summary>
        public EmailsClient Emails { get; }

        /// <summary>
        /// Create and manage Events through the Resend API.
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// Retrieve API request logs through the Resend API.
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// Retrieve and manage received emails and attachments through the Resend API.
        /// </summary>
        public ReceivingEmailsClient ReceivingEmails { get; }

        /// <summary>
        /// Create and manage Segments through the Resend API.
        /// </summary>
        public SegmentsClient Segments { get; }

        /// <summary>
        /// Create and manage Templates through the Resend API.
        /// </summary>
        public TemplatesClient Templates { get; }

        /// <summary>
        /// Create and manage Topics through the Resend API.
        /// </summary>
        public TopicsClient Topics { get; }

        /// <summary>
        /// Create and manage Webhooks through the Resend API.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}