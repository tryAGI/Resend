#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Update an automation
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.PatchAutomationResponse> EditAutomationsByAutomationIdAsync(
            global::System.Guid automationId,

            global::Resend.PatchAutomationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an automation
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="name">
        /// The name of the automation.
        /// </param>
        /// <param name="status">
        /// The status of the automation.
        /// </param>
        /// <param name="steps">
        /// The steps that compose the automation workflow. Must be provided together with `edges`.
        /// </param>
        /// <param name="edges">
        /// The edges connecting steps in the automation graph. Must be provided together with `steps`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.PatchAutomationResponse> EditAutomationsByAutomationIdAsync(
            global::System.Guid automationId,
            string? name = default,
            global::Resend.PatchAutomationRequestStatus? status = default,
            global::System.Collections.Generic.IList<global::Resend.AutomationStep>? steps = default,
            global::System.Collections.Generic.IList<global::Resend.AutomationEdge>? edges = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}