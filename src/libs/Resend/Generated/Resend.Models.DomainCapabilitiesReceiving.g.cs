
#nullable enable

namespace Resend
{
    /// <summary>
    /// Enable or disable receiving emails to this domain.
    /// </summary>
    public enum DomainCapabilitiesReceiving
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
    public static class DomainCapabilitiesReceivingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainCapabilitiesReceiving value)
        {
            return value switch
            {
                DomainCapabilitiesReceiving.Disabled => "disabled",
                DomainCapabilitiesReceiving.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainCapabilitiesReceiving? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => DomainCapabilitiesReceiving.Disabled,
                "enabled" => DomainCapabilitiesReceiving.Enabled,
                _ => null,
            };
        }
    }
}