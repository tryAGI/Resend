
#nullable enable

namespace Resend
{
    /// <summary>
    /// The current status of the automation.
    /// </summary>
    public enum AutomationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationStatus value)
        {
            return value switch
            {
                AutomationStatus.Disabled => "disabled",
                AutomationStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutomationStatus.Disabled,
                "enabled" => AutomationStatus.Enabled,
                _ => null,
            };
        }
    }
}