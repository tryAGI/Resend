#nullable enable

namespace Resend
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Duplicate a template
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Resend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Resend.DuplicateTemplateResponseSuccess> CreateTemplatesByIdDuplicateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}