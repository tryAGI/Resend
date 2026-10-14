
#nullable enable

namespace Resend
{
    /// <summary>
    /// `standalone` for a new conversation, or `reply`.<br/>
    /// Example: reply
    /// </summary>
    public enum InboxEventDraftType
    {
        /// <summary>
        ///
        /// </summary>
        Reply,
        /// <summary>
        ///
        /// </summary>
        Standalone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxEventDraftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxEventDraftType value)
        {
            return value switch
            {
                InboxEventDraftType.Reply => "reply",
                InboxEventDraftType.Standalone => "standalone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxEventDraftType? ToEnum(string value)
        {
            return value switch
            {
                "reply" => InboxEventDraftType.Reply,
                "standalone" => InboxEventDraftType.Standalone,
                _ => null,
            };
        }
    }
}