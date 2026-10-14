
#nullable enable

namespace Resend
{
    /// <summary>
    /// Whether the email was received by the inbox or sent from it.<br/>
    /// Example: inbound
    /// </summary>
    public enum InboxEventEmailDirection
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
    public static class InboxEventEmailDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxEventEmailDirection value)
        {
            return value switch
            {
                InboxEventEmailDirection.Inbound => "inbound",
                InboxEventEmailDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxEventEmailDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => InboxEventEmailDirection.Inbound,
                "outbound" => InboxEventEmailDirection.Outbound,
                _ => null,
            };
        }
    }
}