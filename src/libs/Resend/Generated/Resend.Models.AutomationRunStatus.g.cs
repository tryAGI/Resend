
#nullable enable

namespace Resend
{
    /// <summary>
    /// The current status of the automation run.
    /// </summary>
    public enum AutomationRunStatus
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
    public static class AutomationRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRunStatus value)
        {
            return value switch
            {
                AutomationRunStatus.Cancelled => "cancelled",
                AutomationRunStatus.Completed => "completed",
                AutomationRunStatus.Failed => "failed",
                AutomationRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AutomationRunStatus.Cancelled,
                "completed" => AutomationRunStatus.Completed,
                "failed" => AutomationRunStatus.Failed,
                "running" => AutomationRunStatus.Running,
                _ => null,
            };
        }
    }
}