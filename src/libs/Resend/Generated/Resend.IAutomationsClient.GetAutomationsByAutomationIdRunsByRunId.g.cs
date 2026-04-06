#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Retrieve a single automation run
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.AutomationRun> GetAutomationsByAutomationIdRunsByRunIdAsync(
            global::System.Guid automationId,
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}