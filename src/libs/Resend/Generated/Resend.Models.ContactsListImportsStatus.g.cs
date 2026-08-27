
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum ContactsListImportsStatus
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
    public static class ContactsListImportsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactsListImportsStatus value)
        {
            return value switch
            {
                ContactsListImportsStatus.Completed => "completed",
                ContactsListImportsStatus.Failed => "failed",
                ContactsListImportsStatus.InProgress => "in_progress",
                ContactsListImportsStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactsListImportsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ContactsListImportsStatus.Completed,
                "failed" => ContactsListImportsStatus.Failed,
                "in_progress" => ContactsListImportsStatus.InProgress,
                "queued" => ContactsListImportsStatus.Queued,
                _ => null,
            };
        }
    }
}