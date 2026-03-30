
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Log
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: log
        /// </summary>
        /// <example>log</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.LogMethodJsonConverter))]
        public global::Resend.LogMethod? Method { get; set; }

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
        /// The request body sent to the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public object? RequestBody { get; set; }

        /// <summary>
        /// The response body returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public object? ResponseBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: log
        /// </param>
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
        /// <param name="requestBody">
        /// The request body sent to the API.
        /// </param>
        /// <param name="responseBody">
        /// The response body returned by the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Log(
            string? @object,
            global::System.Guid? id,
            global::System.DateTime? createdAt,
            string? endpoint,
            global::Resend.LogMethod? method,
            int? responseStatus,
            string? userAgent,
            object? requestBody,
            object? responseBody)
        {
            this.Object = @object;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint;
            this.Method = method;
            this.ResponseStatus = responseStatus;
            this.UserAgent = userAgent;
            this.RequestBody = requestBody;
            this.ResponseBody = responseBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        public Log()
        {
        }
    }
}