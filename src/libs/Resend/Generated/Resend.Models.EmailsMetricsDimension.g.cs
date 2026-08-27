
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum EmailsMetricsDimension
    {
        /// <summary>
        ///
        /// </summary>
        Broadcast,
        /// <summary>
        ///
        /// </summary>
        Domain,
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        Period,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailsMetricsDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailsMetricsDimension value)
        {
            return value switch
            {
                EmailsMetricsDimension.Broadcast => "broadcast",
                EmailsMetricsDimension.Domain => "domain",
                EmailsMetricsDimension.Email => "email",
                EmailsMetricsDimension.Period => "period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailsMetricsDimension? ToEnum(string value)
        {
            return value switch
            {
                "broadcast" => EmailsMetricsDimension.Broadcast,
                "domain" => EmailsMetricsDimension.Domain,
                "email" => EmailsMetricsDimension.Email,
                "period" => EmailsMetricsDimension.Period,
                _ => null,
            };
        }
    }
}