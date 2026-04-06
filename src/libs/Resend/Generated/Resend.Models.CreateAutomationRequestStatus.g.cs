
#nullable enable

namespace Resend
{
    /// <summary>
    /// The initial status of the automation. Defaults to `disabled`.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CreateAutomationRequestStatus
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
    public static class CreateAutomationRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAutomationRequestStatus value)
        {
            return value switch
            {
                CreateAutomationRequestStatus.Disabled => "disabled",
                CreateAutomationRequestStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAutomationRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateAutomationRequestStatus.Disabled,
                "enabled" => CreateAutomationRequestStatus.Enabled,
                _ => null,
            };
        }
    }
}