
#nullable enable

namespace Resend
{
    /// <summary>
    /// The folder the thread moved to.<br/>
    /// Example: archive
    /// </summary>
    public enum InboxThreadFolderUpdatedEventDataTo
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
    public static class InboxThreadFolderUpdatedEventDataToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxThreadFolderUpdatedEventDataTo value)
        {
            return value switch
            {
                InboxThreadFolderUpdatedEventDataTo.Archive => "archive",
                InboxThreadFolderUpdatedEventDataTo.Inbox => "inbox",
                InboxThreadFolderUpdatedEventDataTo.Spam => "spam",
                InboxThreadFolderUpdatedEventDataTo.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxThreadFolderUpdatedEventDataTo? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxThreadFolderUpdatedEventDataTo.Archive,
                "inbox" => InboxThreadFolderUpdatedEventDataTo.Inbox,
                "spam" => InboxThreadFolderUpdatedEventDataTo.Spam,
                "trash" => InboxThreadFolderUpdatedEventDataTo.Trash,
                _ => null,
            };
        }
    }
}