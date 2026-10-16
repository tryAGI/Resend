
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum InboxAgentAction
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
    public static class InboxAgentActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxAgentAction value)
        {
            return value switch
            {
                InboxAgentAction.AddLabels => "add_labels",
                InboxAgentAction.Archive => "archive",
                InboxAgentAction.AssignThread => "assign_thread",
                InboxAgentAction.DraftReply => "draft_reply",
                InboxAgentAction.ForwardThread => "forward_thread",
                InboxAgentAction.MarkAsSpam => "mark_as_spam",
                InboxAgentAction.MoveToTrash => "move_to_trash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxAgentAction? ToEnum(string value)
        {
            return value switch
            {
                "add_labels" => InboxAgentAction.AddLabels,
                "archive" => InboxAgentAction.Archive,
                "assign_thread" => InboxAgentAction.AssignThread,
                "draft_reply" => InboxAgentAction.DraftReply,
                "forward_thread" => InboxAgentAction.ForwardThread,
                "mark_as_spam" => InboxAgentAction.MarkAsSpam,
                "move_to_trash" => InboxAgentAction.MoveToTrash,
                _ => null,
            };
        }
    }
}