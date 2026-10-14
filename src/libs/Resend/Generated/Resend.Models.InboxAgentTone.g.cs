
#nullable enable

namespace Resend
{
    /// <summary>
    /// The tone the agent writes in. Null when no tone is set.<br/>
    /// Example: concise_professional
    /// </summary>
    public enum InboxAgentTone
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
    public static class InboxAgentToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxAgentTone value)
        {
            return value switch
            {
                InboxAgentTone.ConciseCasual => "concise_casual",
                InboxAgentTone.ConciseProfessional => "concise_professional",
                InboxAgentTone.ExpandedCasual => "expanded_casual",
                InboxAgentTone.ExpandedProfessional => "expanded_professional",
                InboxAgentTone.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxAgentTone? ToEnum(string value)
        {
            return value switch
            {
                "concise_casual" => InboxAgentTone.ConciseCasual,
                "concise_professional" => InboxAgentTone.ConciseProfessional,
                "expanded_casual" => InboxAgentTone.ExpandedCasual,
                "expanded_professional" => InboxAgentTone.ExpandedProfessional,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => InboxAgentTone.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}