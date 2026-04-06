
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of edge. Defaults to `default`.<br/>
    /// Default Value: default
    /// </summary>
    public enum AutomationEdgeEdgeType
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
    public static class AutomationEdgeEdgeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationEdgeEdgeType value)
        {
            return value switch
            {
                AutomationEdgeEdgeType.ConditionMet => "condition_met",
                AutomationEdgeEdgeType.ConditionNotMet => "condition_not_met",
                AutomationEdgeEdgeType.Default => "default",
                AutomationEdgeEdgeType.EventReceived => "event_received",
                AutomationEdgeEdgeType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationEdgeEdgeType? ToEnum(string value)
        {
            return value switch
            {
                "condition_met" => AutomationEdgeEdgeType.ConditionMet,
                "condition_not_met" => AutomationEdgeEdgeType.ConditionNotMet,
                "default" => AutomationEdgeEdgeType.Default,
                "event_received" => AutomationEdgeEdgeType.EventReceived,
                "timeout" => AutomationEdgeEdgeType.Timeout,
                _ => null,
            };
        }
    }
}