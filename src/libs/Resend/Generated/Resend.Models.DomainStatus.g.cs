
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the domain.<br/>
    /// Example: not_started
    /// </summary>
    public enum DomainStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        PartiallyFailed,
        /// <summary>
        /// 
        /// </summary>
        PartiallyVerified,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainStatus value)
        {
            return value switch
            {
                DomainStatus.Failed => "failed",
                DomainStatus.NotStarted => "not_started",
                DomainStatus.PartiallyFailed => "partially_failed",
                DomainStatus.PartiallyVerified => "partially_verified",
                DomainStatus.Pending => "pending",
                DomainStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DomainStatus.Failed,
                "not_started" => DomainStatus.NotStarted,
                "partially_failed" => DomainStatus.PartiallyFailed,
                "partially_verified" => DomainStatus.PartiallyVerified,
                "pending" => DomainStatus.Pending,
                "verified" => DomainStatus.Verified,
                _ => null,
            };
        }
    }
}