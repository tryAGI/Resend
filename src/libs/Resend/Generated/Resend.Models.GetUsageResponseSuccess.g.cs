
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageResponseSuccess
    {
        /// <summary>
        /// The type of object.<br/>
        /// Example: usage
        /// </summary>
        /// <example>usage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::Resend.GetUsageResponseSuccessEmails? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        public global::Resend.GetUsageResponseSuccessContacts? Contacts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::Resend.GetUsageResponseSuccessSegments? Segments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcasts")]
        public global::Resend.GetUsageResponseSuccessBroadcasts? Broadcasts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_credits")]
        public global::Resend.GetUsageResponseSuccessAiCredits? AiCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automation_runs")]
        public global::Resend.GetUsageResponseSuccessAutomationRuns? AutomationRuns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::Resend.GetUsageResponseSuccessDomains? Domains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        public global::Resend.GetUsageResponseSuccessRateLimit? RateLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccess" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object.<br/>
        /// Example: usage
        /// </param>
        /// <param name="emails"></param>
        /// <param name="contacts"></param>
        /// <param name="segments"></param>
        /// <param name="broadcasts"></param>
        /// <param name="aiCredits"></param>
        /// <param name="automationRuns"></param>
        /// <param name="domains"></param>
        /// <param name="rateLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseSuccess(
            string? @object,
            global::Resend.GetUsageResponseSuccessEmails? emails,
            global::Resend.GetUsageResponseSuccessContacts? contacts,
            global::Resend.GetUsageResponseSuccessSegments? segments,
            global::Resend.GetUsageResponseSuccessBroadcasts? broadcasts,
            global::Resend.GetUsageResponseSuccessAiCredits? aiCredits,
            global::Resend.GetUsageResponseSuccessAutomationRuns? automationRuns,
            global::Resend.GetUsageResponseSuccessDomains? domains,
            global::Resend.GetUsageResponseSuccessRateLimit? rateLimit)
        {
            this.Object = @object;
            this.Emails = emails;
            this.Contacts = contacts;
            this.Segments = segments;
            this.Broadcasts = broadcasts;
            this.AiCredits = aiCredits;
            this.AutomationRuns = automationRuns;
            this.Domains = domains;
            this.RateLimit = rateLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSuccess" /> class.
        /// </summary>
        public GetUsageResponseSuccess()
        {
        }

    }
}