
#nullable enable

namespace Resend
{
    /// <summary>
    /// The current status of the automation.
    /// </summary>
    public enum AutomationListItemStatus
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
    public static class AutomationListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationListItemStatus value)
        {
            return value switch
            {
                AutomationListItemStatus.Disabled => "disabled",
                AutomationListItemStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutomationListItemStatus.Disabled,
                "enabled" => AutomationListItemStatus.Enabled,
                _ => null,
            };
        }
    }
}