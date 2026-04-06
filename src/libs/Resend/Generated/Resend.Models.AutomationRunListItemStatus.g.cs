
#nullable enable

namespace Resend
{
    /// <summary>
    /// The current status of the automation run.
    /// </summary>
    public enum AutomationRunListItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRunListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRunListItemStatus value)
        {
            return value switch
            {
                AutomationRunListItemStatus.Cancelled => "cancelled",
                AutomationRunListItemStatus.Completed => "completed",
                AutomationRunListItemStatus.Failed => "failed",
                AutomationRunListItemStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRunListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AutomationRunListItemStatus.Cancelled,
                "completed" => AutomationRunListItemStatus.Completed,
                "failed" => AutomationRunListItemStatus.Failed,
                "running" => AutomationRunListItemStatus.Running,
                _ => null,
            };
        }
    }
}