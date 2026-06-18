
#nullable enable

namespace Resend
{
    /// <summary>
    /// Why the claim is currently blocked, if applicable.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum DomainClaimBlockedReason
    {
        /// <summary>
        /// 
        /// </summary>
        GracePeriod,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        PendingScheduledEmails,
        /// <summary>
        /// 
        /// </summary>
        RecentOwnerActivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainClaimBlockedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainClaimBlockedReason value)
        {
            return value switch
            {
                DomainClaimBlockedReason.GracePeriod => "grace_period",
                DomainClaimBlockedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                DomainClaimBlockedReason.PendingScheduledEmails => "pending_scheduled_emails",
                DomainClaimBlockedReason.RecentOwnerActivity => "recent_owner_activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainClaimBlockedReason? ToEnum(string value)
        {
            return value switch
            {
                "grace_period" => DomainClaimBlockedReason.GracePeriod,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => DomainClaimBlockedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "pending_scheduled_emails" => DomainClaimBlockedReason.PendingScheduledEmails,
                "recent_owner_activity" => DomainClaimBlockedReason.RecentOwnerActivity,
                _ => null,
            };
        }
    }
}