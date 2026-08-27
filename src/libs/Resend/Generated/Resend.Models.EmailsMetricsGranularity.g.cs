
#nullable enable

namespace Resend
{
    /// <summary>
    /// Default Value: daily
    /// </summary>
    public enum EmailsMetricsGranularity
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
    public static class EmailsMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailsMetricsGranularity value)
        {
            return value switch
            {
                EmailsMetricsGranularity.Daily => "daily",
                EmailsMetricsGranularity.Hourly => "hourly",
                EmailsMetricsGranularity.Monthly => "monthly",
                EmailsMetricsGranularity.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailsMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "daily" => EmailsMetricsGranularity.Daily,
                "hourly" => EmailsMetricsGranularity.Hourly,
                "monthly" => EmailsMetricsGranularity.Monthly,
                "weekly" => EmailsMetricsGranularity.Weekly,
                _ => null,
            };
        }
    }
}