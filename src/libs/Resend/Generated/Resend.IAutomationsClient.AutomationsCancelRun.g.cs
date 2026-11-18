#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Cancel an automation run<br/>
        /// Stops a running automation run. Steps that have not started yet are skipped. Returns 422 if the run has already finished.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CancelAutomationRunResponse> AutomationsCancelRunAsync(
            global::System.Guid automationId,
            global::System.Guid runId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel an automation run<br/>
        /// Stops a running automation run. Steps that have not started yet are skipped. Returns 422 if the run has already finished.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutoSDKHttpResponse<global::Resend.CancelAutomationRunResponse>> AutomationsCancelRunAsResponseAsync(
            global::System.Guid automationId,
            global::System.Guid runId,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}