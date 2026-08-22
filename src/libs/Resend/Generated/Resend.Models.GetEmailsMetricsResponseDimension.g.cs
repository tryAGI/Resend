
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEmailsMetricsResponseDimension
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
    public static class GetEmailsMetricsResponseDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmailsMetricsResponseDimension value)
        {
            return value switch
            {
                GetEmailsMetricsResponseDimension.Broadcast => "broadcast",
                GetEmailsMetricsResponseDimension.Domain => "domain",
                GetEmailsMetricsResponseDimension.Email => "email",
                GetEmailsMetricsResponseDimension.Period => "period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmailsMetricsResponseDimension? ToEnum(string value)
        {
            return value switch
            {
                "broadcast" => GetEmailsMetricsResponseDimension.Broadcast,
                "domain" => GetEmailsMetricsResponseDimension.Domain,
                "email" => GetEmailsMetricsResponseDimension.Email,
                "period" => GetEmailsMetricsResponseDimension.Period,
                _ => null,
            };
        }
    }
}