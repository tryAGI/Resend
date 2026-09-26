
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccessEmails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public global::Resend.GetUsageResponseSuccessEmailsDaily? Daily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly")]
        public global::Resend.GetUsageResponseSuccessEmailsMonthly? Monthly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmails" /> class.
        /// </summary>
        /// <param name="daily"></param>
        /// <param name="monthly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccessEmails(
            global::Resend.GetUsageResponseSuccessEmailsDaily? daily,
            global::Resend.GetUsageResponseSuccessEmailsMonthly? monthly)
        {
            this.Daily = daily;
            this.Monthly = monthly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccessEmails" /> class.
        /// </summary>
        public GetUsageResponseSuccessEmails()
        {
        }

    }
}