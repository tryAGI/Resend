#nullable enable

namespace Resend
{
    public partial interface IAutomationsClient
    {
        /// <summary>
        /// Retrieve a list of automations
        /// </summary>
        /// <param name="status"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.ListAutomationsResponse> GetAutomationsAsync(
            global::Resend.GetAutomationsStatus? status = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}