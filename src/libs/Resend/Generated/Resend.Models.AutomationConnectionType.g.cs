
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of connection. Defaults to `default`.<br/>
    /// Default Value: default
    /// </summary>
    public enum AutomationConnectionType
    {
        /// <summary>
        /// 
        /// </summary>
        ConditionMet,
        /// <summary>
        /// 
        /// </summary>
        ConditionNotMet,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        EventReceived,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationConnectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationConnectionType value)
        {
            return value switch
            {
                AutomationConnectionType.ConditionMet => "condition_met",
                AutomationConnectionType.ConditionNotMet => "condition_not_met",
                AutomationConnectionType.Default => "default",
                AutomationConnectionType.EventReceived => "event_received",
                AutomationConnectionType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationConnectionType? ToEnum(string value)
        {
            return value switch
            {
                "condition_met" => AutomationConnectionType.ConditionMet,
                "condition_not_met" => AutomationConnectionType.ConditionNotMet,
                "default" => AutomationConnectionType.Default,
                "event_received" => AutomationConnectionType.EventReceived,
                "timeout" => AutomationConnectionType.Timeout,
                _ => null,
            };
        }
    }
}