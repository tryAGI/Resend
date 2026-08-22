#nullable enable

namespace Resend
{
    public partial interface IEmailsClient
    {
        /// <summary>
        /// Retrieve account-level email metrics
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="granularity">
        /// Default Value: daily
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="dimensions"></param>
        /// <param name="domainId"></param>
        /// <param name="emailId"></param>
        /// <param name="broadcastId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.GetEmailsMetricsResponse> EmailsMetricsAsync(
            string? startDate = default,
            string? endDate = default,
            string? timezone = default,
            global::Resend.EmailsMetricsGranularity? granularity = default,
            global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>? metrics = default,
            global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>? dimensions = default,
            global::System.Collections.Generic.IList<global::System.Guid>? domainId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? emailId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? broadcastId = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve account-level email metrics
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="granularity">
        /// Default Value: daily
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="dimensions"></param>
        /// <param name="domainId"></param>
        /// <param name="emailId"></param>
        /// <param name="broadcastId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.GetEmailsMetricsResponse>> EmailsMetricsAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? timezone = default,
            global::Resend.EmailsMetricsGranularity? granularity = default,
            global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>? metrics = default,
            global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>? dimensions = default,
            global::System.Collections.Generic.IList<global::System.Guid>? domainId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? emailId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? broadcastId = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}