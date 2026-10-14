
#nullable enable

namespace Resend
{
    /// <summary>
    /// The tone the agent writes in. Send null to clear the tone.<br/>
    /// Example: concise_professional
    /// </summary>
    public enum UpdateInboxAgentOptionsTone
    {
        /// <summary>
        ///
        /// </summary>
        ConciseCasual,
        /// <summary>
        ///
        /// </summary>
        ConciseProfessional,
        /// <summary>
        ///
        /// </summary>
        ExpandedCasual,
        /// <summary>
        ///
        /// </summary>
        ExpandedProfessional,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInboxAgentOptionsToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboxAgentOptionsTone value)
        {
            return value switch
            {
                UpdateInboxAgentOptionsTone.ConciseCasual => "concise_casual",
                UpdateInboxAgentOptionsTone.ConciseProfessional => "concise_professional",
                UpdateInboxAgentOptionsTone.ExpandedCasual => "expanded_casual",
                UpdateInboxAgentOptionsTone.ExpandedProfessional => "expanded_professional",
                UpdateInboxAgentOptionsTone.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboxAgentOptionsTone? ToEnum(string value)
        {
            return value switch
            {
                "concise_casual" => UpdateInboxAgentOptionsTone.ConciseCasual,
                "concise_professional" => UpdateInboxAgentOptionsTone.ConciseProfessional,
                "expanded_casual" => UpdateInboxAgentOptionsTone.ExpandedCasual,
                "expanded_professional" => UpdateInboxAgentOptionsTone.ExpandedProfessional,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => UpdateInboxAgentOptionsTone.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}