
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateInboxAgentOptionsAction
    {
        /// <summary>
        ///
        /// </summary>
        AddLabels,
        /// <summary>
        ///
        /// </summary>
        Archive,
        /// <summary>
        ///
        /// </summary>
        AssignThread,
        /// <summary>
        ///
        /// </summary>
        DraftReply,
        /// <summary>
        ///
        /// </summary>
        ForwardThread,
        /// <summary>
        ///
        /// </summary>
        MarkAsSpam,
        /// <summary>
        ///
        /// </summary>
        MoveToTrash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInboxAgentOptionsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboxAgentOptionsAction value)
        {
            return value switch
            {
                UpdateInboxAgentOptionsAction.AddLabels => "add_labels",
                UpdateInboxAgentOptionsAction.Archive => "archive",
                UpdateInboxAgentOptionsAction.AssignThread => "assign_thread",
                UpdateInboxAgentOptionsAction.DraftReply => "draft_reply",
                UpdateInboxAgentOptionsAction.ForwardThread => "forward_thread",
                UpdateInboxAgentOptionsAction.MarkAsSpam => "mark_as_spam",
                UpdateInboxAgentOptionsAction.MoveToTrash => "move_to_trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboxAgentOptionsAction? ToEnum(string value)
        {
            return value switch
            {
                "add_labels" => UpdateInboxAgentOptionsAction.AddLabels,
                "archive" => UpdateInboxAgentOptionsAction.Archive,
                "assign_thread" => UpdateInboxAgentOptionsAction.AssignThread,
                "draft_reply" => UpdateInboxAgentOptionsAction.DraftReply,
                "forward_thread" => UpdateInboxAgentOptionsAction.ForwardThread,
                "mark_as_spam" => UpdateInboxAgentOptionsAction.MarkAsSpam,
                "move_to_trash" => UpdateInboxAgentOptionsAction.MoveToTrash,
                _ => null,
            };
        }
    }
}