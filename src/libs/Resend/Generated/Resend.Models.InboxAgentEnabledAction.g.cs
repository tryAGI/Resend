
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum InboxAgentEnabledAction
    {
        /// <summary>
        ///
        /// </summary>
        AddLabels,
        /// <summary>
        ///
        /// </summary>
        ArchiveThread,
        /// <summary>
        ///
        /// </summary>
        AssignThread,
        /// <summary>
        ///
        /// </summary>
        DeleteThread,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxAgentEnabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxAgentEnabledAction value)
        {
            return value switch
            {
                InboxAgentEnabledAction.AddLabels => "add_labels",
                InboxAgentEnabledAction.ArchiveThread => "archive_thread",
                InboxAgentEnabledAction.AssignThread => "assign_thread",
                InboxAgentEnabledAction.DeleteThread => "delete_thread",
                InboxAgentEnabledAction.DraftReply => "draft_reply",
                InboxAgentEnabledAction.ForwardThread => "forward_thread",
                InboxAgentEnabledAction.MarkAsSpam => "mark_as_spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxAgentEnabledAction? ToEnum(string value)
        {
            return value switch
            {
                "add_labels" => InboxAgentEnabledAction.AddLabels,
                "archive_thread" => InboxAgentEnabledAction.ArchiveThread,
                "assign_thread" => InboxAgentEnabledAction.AssignThread,
                "delete_thread" => InboxAgentEnabledAction.DeleteThread,
                "draft_reply" => InboxAgentEnabledAction.DraftReply,
                "forward_thread" => InboxAgentEnabledAction.ForwardThread,
                "mark_as_spam" => InboxAgentEnabledAction.MarkAsSpam,
                _ => null,
            };
        }
    }
}