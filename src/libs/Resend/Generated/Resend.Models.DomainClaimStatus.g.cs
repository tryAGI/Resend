
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the claim.<br/>
    /// Example: pending
    /// </summary>
    public enum DomainClaimStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Superseded,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainClaimStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainClaimStatus value)
        {
            return value switch
            {
                DomainClaimStatus.Blocked => "blocked",
                DomainClaimStatus.Canceled => "canceled",
                DomainClaimStatus.Completed => "completed",
                DomainClaimStatus.Expired => "expired",
                DomainClaimStatus.Failed => "failed",
                DomainClaimStatus.Pending => "pending",
                DomainClaimStatus.Superseded => "superseded",
                DomainClaimStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainClaimStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => DomainClaimStatus.Blocked,
                "canceled" => DomainClaimStatus.Canceled,
                "completed" => DomainClaimStatus.Completed,
                "expired" => DomainClaimStatus.Expired,
                "failed" => DomainClaimStatus.Failed,
                "pending" => DomainClaimStatus.Pending,
                "superseded" => DomainClaimStatus.Superseded,
                "verified" => DomainClaimStatus.Verified,
                _ => null,
            };
        }
    }
}