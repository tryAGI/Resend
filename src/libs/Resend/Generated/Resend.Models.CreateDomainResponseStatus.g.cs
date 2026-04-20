
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the domain.
    /// </summary>
    public enum CreateDomainResponseStatus
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
    public static class CreateDomainResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDomainResponseStatus value)
        {
            return value switch
            {
                CreateDomainResponseStatus.Failed => "failed",
                CreateDomainResponseStatus.NotStarted => "not_started",
                CreateDomainResponseStatus.PartiallyFailed => "partially_failed",
                CreateDomainResponseStatus.PartiallyVerified => "partially_verified",
                CreateDomainResponseStatus.Pending => "pending",
                CreateDomainResponseStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDomainResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CreateDomainResponseStatus.Failed,
                "not_started" => CreateDomainResponseStatus.NotStarted,
                "partially_failed" => CreateDomainResponseStatus.PartiallyFailed,
                "partially_verified" => CreateDomainResponseStatus.PartiallyVerified,
                "pending" => CreateDomainResponseStatus.Pending,
                "verified" => CreateDomainResponseStatus.Verified,
                _ => null,
            };
        }
    }
}