
#nullable enable

namespace Resend
{
    /// <summary>
    /// enforced | opportunistic.<br/>
    /// Default Value: opportunistic
    /// </summary>
    public enum UpdateDomainOptionsTls
    {
        /// <summary>
        ///
        /// </summary>
        Enforced,
        /// <summary>
        ///
        /// </summary>
        Opportunistic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDomainOptionsTlsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDomainOptionsTls value)
        {
            return value switch
            {
                UpdateDomainOptionsTls.Enforced => "enforced",
                UpdateDomainOptionsTls.Opportunistic => "opportunistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDomainOptionsTls? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => UpdateDomainOptionsTls.Enforced,
                "opportunistic" => UpdateDomainOptionsTls.Opportunistic,
                _ => null,
            };
        }
    }
}