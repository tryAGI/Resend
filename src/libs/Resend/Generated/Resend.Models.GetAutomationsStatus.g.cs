
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAutomationsStatus
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
    public static class GetAutomationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAutomationsStatus value)
        {
            return value switch
            {
                GetAutomationsStatus.Disabled => "disabled",
                GetAutomationsStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAutomationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetAutomationsStatus.Disabled,
                "enabled" => GetAutomationsStatus.Enabled,
                _ => null,
            };
        }
    }
}