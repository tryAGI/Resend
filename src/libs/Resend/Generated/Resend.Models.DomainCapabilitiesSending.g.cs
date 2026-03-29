
#nullable enable

namespace Resend
{
    /// <summary>
    /// Enable or disable sending emails from this domain.
    /// </summary>
    public enum DomainCapabilitiesSending
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
    public static class DomainCapabilitiesSendingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainCapabilitiesSending value)
        {
            return value switch
            {
                DomainCapabilitiesSending.Disabled => "disabled",
                DomainCapabilitiesSending.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainCapabilitiesSending? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => DomainCapabilitiesSending.Disabled,
                "enabled" => DomainCapabilitiesSending.Enabled,
                _ => null,
            };
        }
    }
}