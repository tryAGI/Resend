
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum InboxesListThreadsFolder
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
    public static class InboxesListThreadsFolderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxesListThreadsFolder value)
        {
            return value switch
            {
                InboxesListThreadsFolder.Archive => "archive",
                InboxesListThreadsFolder.Inbox => "inbox",
                InboxesListThreadsFolder.Sent => "sent",
                InboxesListThreadsFolder.Spam => "spam",
                InboxesListThreadsFolder.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxesListThreadsFolder? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxesListThreadsFolder.Archive,
                "inbox" => InboxesListThreadsFolder.Inbox,
                "sent" => InboxesListThreadsFolder.Sent,
                "spam" => InboxesListThreadsFolder.Spam,
                "trash" => InboxesListThreadsFolder.Trash,
                _ => null,
            };
        }
    }
}