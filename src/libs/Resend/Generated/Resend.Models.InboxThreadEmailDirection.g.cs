
#nullable enable

namespace Resend
{
    /// <summary>
    /// Whether the inbox received the message (`inbound`) or sent it (`outbound`). A message the inbox sent to itself is `inbound`, so a reply to it goes to its sender.<br/>
    /// Example: inbound
    /// </summary>
    public enum InboxThreadEmailDirection
    {
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxThreadEmailDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxThreadEmailDirection value)
        {
            return value switch
            {
                InboxThreadEmailDirection.Inbound => "inbound",
                InboxThreadEmailDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxThreadEmailDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => InboxThreadEmailDirection.Inbound,
                "outbound" => InboxThreadEmailDirection.Outbound,
                _ => null,
            };
        }
    }
}