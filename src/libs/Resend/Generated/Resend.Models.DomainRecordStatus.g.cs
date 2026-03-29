
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the record.
    /// </summary>
    public enum DomainRecordStatus
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
    public static class DomainRecordStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainRecordStatus value)
        {
            return value switch
            {
                DomainRecordStatus.Failed => "failed",
                DomainRecordStatus.NotStarted => "not_started",
                DomainRecordStatus.Pending => "pending",
                DomainRecordStatus.TemporaryFailure => "temporary_failure",
                DomainRecordStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainRecordStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DomainRecordStatus.Failed,
                "not_started" => DomainRecordStatus.NotStarted,
                "pending" => DomainRecordStatus.Pending,
                "temporary_failure" => DomainRecordStatus.TemporaryFailure,
                "verified" => DomainRecordStatus.Verified,
                _ => null,
            };
        }
    }
}