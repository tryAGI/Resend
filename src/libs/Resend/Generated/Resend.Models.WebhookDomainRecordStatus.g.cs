
#nullable enable

namespace Resend
{
    /// <summary>
    /// Verification status of this specific record.
    /// </summary>
    public enum WebhookDomainRecordStatus
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        TemporaryFailure,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDomainRecordStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDomainRecordStatus value)
        {
            return value switch
            {
                WebhookDomainRecordStatus.Failed => "failed",
                WebhookDomainRecordStatus.NotStarted => "not_started",
                WebhookDomainRecordStatus.Pending => "pending",
                WebhookDomainRecordStatus.TemporaryFailure => "temporary_failure",
                WebhookDomainRecordStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDomainRecordStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => WebhookDomainRecordStatus.Failed,
                "not_started" => WebhookDomainRecordStatus.NotStarted,
                "pending" => WebhookDomainRecordStatus.Pending,
                "temporary_failure" => WebhookDomainRecordStatus.TemporaryFailure,
                "verified" => WebhookDomainRecordStatus.Verified,
                _ => null,
            };
        }
    }
}