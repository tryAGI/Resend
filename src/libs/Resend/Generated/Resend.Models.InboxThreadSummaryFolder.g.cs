
#nullable enable

namespace Resend
{
    /// <summary>
    /// The folder the thread is in.<br/>
    /// Example: inbox
    /// </summary>
    public enum InboxThreadSummaryFolder
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
    public static class InboxThreadSummaryFolderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxThreadSummaryFolder value)
        {
            return value switch
            {
                InboxThreadSummaryFolder.Archive => "archive",
                InboxThreadSummaryFolder.Inbox => "inbox",
                InboxThreadSummaryFolder.Sent => "sent",
                InboxThreadSummaryFolder.Spam => "spam",
                InboxThreadSummaryFolder.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxThreadSummaryFolder? ToEnum(string value)
        {
            return value switch
            {
                "archive" => InboxThreadSummaryFolder.Archive,
                "inbox" => InboxThreadSummaryFolder.Inbox,
                "sent" => InboxThreadSummaryFolder.Sent,
                "spam" => InboxThreadSummaryFolder.Spam,
                "trash" => InboxThreadSummaryFolder.Trash,
                _ => null,
            };
        }
    }
}