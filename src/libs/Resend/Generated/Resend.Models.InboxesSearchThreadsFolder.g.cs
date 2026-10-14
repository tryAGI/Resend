
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum InboxesSearchThreadsFolder
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
    public static class InboxesSearchThreadsFolderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxesSearchThreadsFolder value)
        {
            return value switch
            {
                InboxesSearchThreadsFolder.Archive => "archive",
                InboxesSearchThreadsFolder.Inbox => "inbox",
                InboxesSearchThreadsFolder.Sent => "sent",
                InboxesSearchThreadsFolder.Spam => "spam",
                InboxesSearchThreadsFolder.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxesSearchThreadsFolder? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxesSearchThreadsFolder.Archive,
                "inbox" => InboxesSearchThreadsFolder.Inbox,
                "sent" => InboxesSearchThreadsFolder.Sent,
                "spam" => InboxesSearchThreadsFolder.Spam,
                "trash" => InboxesSearchThreadsFolder.Trash,
                _ => null,
            };
        }
    }
}