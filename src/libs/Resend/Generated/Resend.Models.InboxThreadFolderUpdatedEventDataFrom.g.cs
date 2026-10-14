
#nullable enable

namespace Resend
{
    /// <summary>
    /// The folder the thread was in.<br/>
    /// Example: inbox
    /// </summary>
    public enum InboxThreadFolderUpdatedEventDataFrom
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
        Spam,
        /// <summary>
        ///
        /// </summary>
        Trash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxThreadFolderUpdatedEventDataFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxThreadFolderUpdatedEventDataFrom value)
        {
            return value switch
            {
                InboxThreadFolderUpdatedEventDataFrom.Archive => "archive",
                InboxThreadFolderUpdatedEventDataFrom.Inbox => "inbox",
                InboxThreadFolderUpdatedEventDataFrom.Spam => "spam",
                InboxThreadFolderUpdatedEventDataFrom.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxThreadFolderUpdatedEventDataFrom? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxThreadFolderUpdatedEventDataFrom.Archive,
                "inbox" => InboxThreadFolderUpdatedEventDataFrom.Inbox,
                "spam" => InboxThreadFolderUpdatedEventDataFrom.Spam,
                "trash" => InboxThreadFolderUpdatedEventDataFrom.Trash,
                _ => null,
            };
        }
    }
}