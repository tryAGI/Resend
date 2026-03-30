
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogSummary
    {
        /// <summary>
        /// The log ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The date the log was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The API endpoint that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// The HTTP method used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.LogSummaryMethodJsonConverter))]
        public global::Resend.LogSummaryMethod? Method { get; set; }

        /// <summary>
        /// The HTTP status code of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_status")]
        public int? ResponseStatus { get; set; }

        /// <summary>
        /// The user agent of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The log ID.
        /// </param>
        /// <param name="createdAt">
        /// The date the log was created.
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint that was called.
        /// </param>
        /// <param name="method">
        /// The HTTP method used.
        /// </param>
        /// <param name="responseStatus">
        /// The HTTP status code of the response.
        /// </param>
        /// <param name="userAgent">
        /// The user agent of the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogSummary(
            global::System.Guid? id,
            global::System.DateTime? createdAt,
            string? endpoint,
            global::Resend.LogSummaryMethod? method,
            int? responseStatus,
            string? userAgent)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint;
            this.Method = method;
            this.ResponseStatus = responseStatus;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogSummary" /> class.
        /// </summary>
        public LogSummary()
        {
        }
    }
}