
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the domain.<br/>
    /// Example: not_started
    /// </summary>
    public enum ListDomainsItemStatus
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
    public static class ListDomainsItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDomainsItemStatus value)
        {
            return value switch
            {
                ListDomainsItemStatus.Failed => "failed",
                ListDomainsItemStatus.NotStarted => "not_started",
                ListDomainsItemStatus.PartiallyFailed => "partially_failed",
                ListDomainsItemStatus.PartiallyVerified => "partially_verified",
                ListDomainsItemStatus.Pending => "pending",
                ListDomainsItemStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDomainsItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ListDomainsItemStatus.Failed,
                "not_started" => ListDomainsItemStatus.NotStarted,
                "partially_failed" => ListDomainsItemStatus.PartiallyFailed,
                "partially_verified" => ListDomainsItemStatus.PartiallyVerified,
                "pending" => ListDomainsItemStatus.Pending,
                "verified" => ListDomainsItemStatus.Verified,
                _ => null,
            };
        }
    }
}