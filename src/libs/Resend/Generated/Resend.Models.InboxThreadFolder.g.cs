
#nullable enable

namespace Resend
{
    /// <summary>
    /// The folder the thread is in. Every thread is in exactly one folder. `inbox` holds threads with at least one received email. `archive` and `spam` hold threads moved there. `trash` holds threads scheduled for deletion in 30 days. `sent` holds threads whose emails are all outbound, and is assigned automatically.<br/>
    /// Example: inbox
    /// </summary>
    public enum InboxThreadFolder
    {
        /// <summary>
        ///
        /// </summary>
        Archive,
        /// <summary>
        ///
        /// </summary>
        Inbox,
        /// <summary>
        ///
        /// </summary>
        Sent,
        /// <summary>
        ///
        /// </summary>
        Spam,
        /// <summary>
        ///
        /// </summary>
        Trash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxThreadFolderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxThreadFolder value)
        {
            return value switch
            {
                InboxThreadFolder.Archive => "archive",
                InboxThreadFolder.Inbox => "inbox",
                InboxThreadFolder.Sent => "sent",
                InboxThreadFolder.Spam => "spam",
                InboxThreadFolder.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxThreadFolder? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxThreadFolder.Archive,
                "inbox" => InboxThreadFolder.Inbox,
                "sent" => InboxThreadFolder.Sent,
                "spam" => InboxThreadFolder.Spam,
                "trash" => InboxThreadFolder.Trash,
                _ => null,
            };
        }
    }
}