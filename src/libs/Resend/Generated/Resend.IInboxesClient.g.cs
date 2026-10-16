
#nullable enable

namespace Resend
{
    /// <summary>
    /// Create and manage Inboxes through the Resend API. A sending access key can call only these Inboxes endpoints: `POST /inboxes/{inbox_id}/threads/{thread_id}/emails/{email_id}/reply`, `POST /inboxes/{inbox_id}/threads/{thread_id}/emails/{email_id}/forward`, `POST /inboxes/{inbox_id}/drafts` and `POST /inboxes/{inbox_id}/drafts/{draft_id}/send`. When the key is limited to one domain, the inbox address must be on that domain, or the request returns a 403. Every other Inboxes endpoint needs a full access API key, and a sending access key returns a 401 `restricted_api_key`.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IInboxesClient : global::System.IDisposable
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
        /// Creates idempotency keys for generated idempotent requests when the caller does not provide one.
        /// </summary>
        public global::System.Func<string> CreateIdempotencyKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}