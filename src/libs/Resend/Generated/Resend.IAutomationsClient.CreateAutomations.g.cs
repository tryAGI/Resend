#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Create an automation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateAutomationResponse> CreateAutomationsAsync(

            global::Resend.CreateAutomationRequest request,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an automation
        /// </summary>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="status">
        /// The initial status of the automation. Defaults to `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="steps">
        /// The steps that compose the automation workflow. Must include at least one `trigger` step.
        /// </param>
        /// <param name="connections">
        /// The connections between steps in the automation graph.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.CreateAutomationResponse> CreateAutomationsAsync(
            string name,
            global::System.Collections.Generic.IList<global::Resend.AutomationStep> steps,
            global::System.Collections.Generic.IList<global::Resend.AutomationConnection> connections,
            global::Resend.CreateAutomationRequestStatus? status = default,
            global::Resend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}