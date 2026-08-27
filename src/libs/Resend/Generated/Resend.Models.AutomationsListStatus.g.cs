
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationsListStatus
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
    public static class AutomationsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationsListStatus value)
        {
            return value switch
            {
                AutomationsListStatus.Disabled => "disabled",
                AutomationsListStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutomationsListStatus.Disabled,
                "enabled" => AutomationsListStatus.Enabled,
                _ => null,
            };
        }
    }
}