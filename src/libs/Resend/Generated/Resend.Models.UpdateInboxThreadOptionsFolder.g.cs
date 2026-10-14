
#nullable enable

namespace Resend
{
    /// <summary>
    /// Moves the thread to this folder. `sent` is assigned automatically and cannot be set.<br/>
    /// Example: archive
    /// </summary>
    public enum UpdateInboxThreadOptionsFolder
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
    public static class UpdateInboxThreadOptionsFolderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboxThreadOptionsFolder value)
        {
            return value switch
            {
                UpdateInboxThreadOptionsFolder.Archive => "archive",
                UpdateInboxThreadOptionsFolder.Inbox => "inbox",
                UpdateInboxThreadOptionsFolder.Spam => "spam",
                UpdateInboxThreadOptionsFolder.Trash => "trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboxThreadOptionsFolder? ToEnum(string value)
        {
            return value switch
            {
                "archive" => UpdateInboxThreadOptionsFolder.Archive,
                "inbox" => UpdateInboxThreadOptionsFolder.Inbox,
                "spam" => UpdateInboxThreadOptionsFolder.Spam,
                "trash" => UpdateInboxThreadOptionsFolder.Trash,
                _ => null,
            };
        }
    }
}