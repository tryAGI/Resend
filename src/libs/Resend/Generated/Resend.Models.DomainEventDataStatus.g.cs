
#nullable enable

namespace Resend
{
    /// <summary>
    /// Aggregated verification status of the domain.
    /// </summary>
    public enum DomainEventDataStatus
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
    public static class DomainEventDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainEventDataStatus value)
        {
            return value switch
            {
                DomainEventDataStatus.Failed => "failed",
                DomainEventDataStatus.NotStarted => "not_started",
                DomainEventDataStatus.PartiallyFailed => "partially_failed",
                DomainEventDataStatus.PartiallyVerified => "partially_verified",
                DomainEventDataStatus.Pending => "pending",
                DomainEventDataStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainEventDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DomainEventDataStatus.Failed,
                "not_started" => DomainEventDataStatus.NotStarted,
                "partially_failed" => DomainEventDataStatus.PartiallyFailed,
                "partially_verified" => DomainEventDataStatus.PartiallyVerified,
                "pending" => DomainEventDataStatus.Pending,
                "verified" => DomainEventDataStatus.Verified,
                _ => null,
            };
        }
    }
}