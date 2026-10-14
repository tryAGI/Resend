
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateInboxAgentOptionsEnabledAction
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
    public static class UpdateInboxAgentOptionsEnabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInboxAgentOptionsEnabledAction value)
        {
            return value switch
            {
                UpdateInboxAgentOptionsEnabledAction.AddLabels => "add_labels",
                UpdateInboxAgentOptionsEnabledAction.ArchiveThread => "archive_thread",
                UpdateInboxAgentOptionsEnabledAction.AssignThread => "assign_thread",
                UpdateInboxAgentOptionsEnabledAction.DeleteThread => "delete_thread",
                UpdateInboxAgentOptionsEnabledAction.DraftReply => "draft_reply",
                UpdateInboxAgentOptionsEnabledAction.ForwardThread => "forward_thread",
                UpdateInboxAgentOptionsEnabledAction.MarkAsSpam => "mark_as_spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInboxAgentOptionsEnabledAction? ToEnum(string value)
        {
            return value switch
            {
                "add_labels" => UpdateInboxAgentOptionsEnabledAction.AddLabels,
                "archive_thread" => UpdateInboxAgentOptionsEnabledAction.ArchiveThread,
                "assign_thread" => UpdateInboxAgentOptionsEnabledAction.AssignThread,
                "delete_thread" => UpdateInboxAgentOptionsEnabledAction.DeleteThread,
                "draft_reply" => UpdateInboxAgentOptionsEnabledAction.DraftReply,
                "forward_thread" => UpdateInboxAgentOptionsEnabledAction.ForwardThread,
                "mark_as_spam" => UpdateInboxAgentOptionsEnabledAction.MarkAsSpam,
                _ => null,
            };
        }
    }
}