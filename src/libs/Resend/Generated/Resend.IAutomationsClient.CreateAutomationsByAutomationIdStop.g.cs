#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Stop an automation
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.StopAutomationResponse> CreateAutomationsByAutomationIdStopAsync(
            global::System.Guid automationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}