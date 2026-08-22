
#nullable enable

namespace Resend
{
    /// <summary>
    /// The bucket size used when `period` is in `dimensions`.
    /// </summary>
    public enum GetEmailsMetricsResponseGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEmailsMetricsResponseGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmailsMetricsResponseGranularity value)
        {
            return value switch
            {
                GetEmailsMetricsResponseGranularity.Daily => "daily",
                GetEmailsMetricsResponseGranularity.Hourly => "hourly",
                GetEmailsMetricsResponseGranularity.Monthly => "monthly",
                GetEmailsMetricsResponseGranularity.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmailsMetricsResponseGranularity? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GetEmailsMetricsResponseGranularity.Daily,
                "hourly" => GetEmailsMetricsResponseGranularity.Hourly,
                "monthly" => GetEmailsMetricsResponseGranularity.Monthly,
                "weekly" => GetEmailsMetricsResponseGranularity.Weekly,
                _ => null,
            };
        }
    }
}