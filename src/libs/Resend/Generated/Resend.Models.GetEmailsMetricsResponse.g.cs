
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetEmailsMetricsResponse
    {
        /// <summary>
        /// Type of the response object.<br/>
        /// Example: metrics
        /// </summary>
        /// <example>metrics</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The start of the requested date range, as an ISO 8601 datetime.<br/>
        /// Example: 2026-07-01T00:00:00.000Z
        /// </summary>
        /// <example>2026-07-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// The end of the requested date range, as an ISO 8601 datetime.<br/>
        /// Example: 2026-07-08T00:00:00.000Z
        /// </summary>
        /// <example>2026-07-08T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// The metrics included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<string>? Metrics { get; set; }

        /// <summary>
        /// The dimensions the response is broken down by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.IList<global::Resend.GetEmailsMetricsResponseDimension>? Dimensions { get; set; }

        /// <summary>
        /// The bucket size used when `period` is in `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Resend.JsonConverters.GetEmailsMetricsResponseGranularityJsonConverter))]
        public global::Resend.GetEmailsMetricsResponseGranularity? Granularity { get; set; }

        /// <summary>
        /// The requested metrics, totaled over the whole date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        public global::System.Collections.Generic.Dictionary<string, double>? Totals { get; set; }

        /// <summary>
        /// One row per unique combination of the requested `dimensions`. Omitted when `dimensions` is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Resend.EmailMetricsDataRow>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailsMetricsResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of the response object.<br/>
        /// Example: metrics
        /// </param>
        /// <param name="startDate">
        /// The start of the requested date range, as an ISO 8601 datetime.<br/>
        /// Example: 2026-07-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// The end of the requested date range, as an ISO 8601 datetime.<br/>
        /// Example: 2026-07-08T00:00:00.000Z
        /// </param>
        /// <param name="metrics">
        /// The metrics included in the response.
        /// </param>
        /// <param name="dimensions">
        /// The dimensions the response is broken down by.
        /// </param>
        /// <param name="granularity">
        /// The bucket size used when `period` is in `dimensions`.
        /// </param>
        /// <param name="totals">
        /// The requested metrics, totaled over the whole date range.
        /// </param>
        /// <param name="data">
        /// One row per unique combination of the requested `dimensions`. Omitted when `dimensions` is empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEmailsMetricsResponse(
            string? @object,
            string? startDate,
            string? endDate,
            global::System.Collections.Generic.IList<string>? metrics,
            global::System.Collections.Generic.IList<global::Resend.GetEmailsMetricsResponseDimension>? dimensions,
            global::Resend.GetEmailsMetricsResponseGranularity? granularity,
            global::System.Collections.Generic.Dictionary<string, double>? totals,
            global::System.Collections.Generic.IList<global::Resend.EmailMetricsDataRow>? data)
        {
            this.Object = @object;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Metrics = metrics;
            this.Dimensions = dimensions;
            this.Granularity = granularity;
            this.Totals = totals;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailsMetricsResponse" /> class.
        /// </summary>
        public GetEmailsMetricsResponse()
        {
        }

    }
}