
#nullable enable

namespace Resend
{
    /// <summary>
    /// The current status of the automation run. `cancelled` runs were stopped on purpose, `skipped` runs ended on their own.
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
        QuotaExceeded,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Skipped,
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
                AutomationRunStatus.QuotaExceeded => "quota_exceeded",
                AutomationRunStatus.Running => "running",
                AutomationRunStatus.Skipped => "skipped",
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
                "quota_exceeded" => AutomationRunStatus.QuotaExceeded,
                "running" => AutomationRunStatus.Running,
                "skipped" => AutomationRunStatus.Skipped,
                _ => null,
            };
        }
    }
}