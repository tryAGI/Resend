
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetContactsImportsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactsImportsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactsImportsStatus value)
        {
            return value switch
            {
                GetContactsImportsStatus.Completed => "completed",
                GetContactsImportsStatus.Failed => "failed",
                GetContactsImportsStatus.InProgress => "in_progress",
                GetContactsImportsStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactsImportsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetContactsImportsStatus.Completed,
                "failed" => GetContactsImportsStatus.Failed,
                "in_progress" => GetContactsImportsStatus.InProgress,
                "queued" => GetContactsImportsStatus.Queued,
                _ => null,
            };
        }
    }
}