
#nullable enable

namespace Resend
{
    /// <summary>
    /// `reply` when the draft replies to an email in an existing thread. `standalone` when the draft starts a new thread.<br/>
    /// Example: standalone
    /// </summary>
    public enum InboxDraftType
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
    public static class InboxDraftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxDraftType value)
        {
            return value switch
            {
                InboxDraftType.Reply => "reply",
                InboxDraftType.Standalone => "standalone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxDraftType? ToEnum(string value)
        {
            return value switch
            {
                "reply" => InboxDraftType.Reply,
                "standalone" => InboxDraftType.Standalone,
                _ => null,
            };
        }
    }
}