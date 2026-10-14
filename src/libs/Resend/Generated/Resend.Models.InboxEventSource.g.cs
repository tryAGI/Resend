
#nullable enable

namespace Resend
{
    /// <summary>
    /// What made the change.<br/>
    /// Example: dashboard
    /// </summary>
    public enum InboxEventSource
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Dashboard,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InboxEventSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InboxEventSource value)
        {
            return value switch
            {
                InboxEventSource.Agent => "agent",
                InboxEventSource.Api => "api",
                InboxEventSource.Dashboard => "dashboard",
                InboxEventSource.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InboxEventSource? ToEnum(string value)
        {
            return value switch
            {
                "agent" => InboxEventSource.Agent,
                "api" => InboxEventSource.Api,
                "dashboard" => InboxEventSource.Dashboard,
                "system" => InboxEventSource.System,
                _ => null,
            };
        }
    }
}