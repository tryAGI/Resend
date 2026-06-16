
#nullable enable

namespace Resend
{
    /// <summary>
    /// Current status of the contact import.<br/>
    /// Example: completed
    /// </summary>
    public enum ContactImportStatus
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
    public static class ContactImportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactImportStatus value)
        {
            return value switch
            {
                ContactImportStatus.Completed => "completed",
                ContactImportStatus.Failed => "failed",
                ContactImportStatus.InProgress => "in_progress",
                ContactImportStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactImportStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ContactImportStatus.Completed,
                "failed" => ContactImportStatus.Failed,
                "in_progress" => ContactImportStatus.InProgress,
                "queued" => ContactImportStatus.Queued,
                _ => null,
            };
        }
    }
}