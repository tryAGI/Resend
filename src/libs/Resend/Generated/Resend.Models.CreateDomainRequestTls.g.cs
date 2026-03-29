
#nullable enable

namespace Resend
{
    /// <summary>
    /// TLS mode. Opportunistic attempts secure connection but falls back to unencrypted. Enforced requires TLS or email won't be sent.<br/>
    /// Default Value: opportunistic
    /// </summary>
    public enum CreateDomainRequestTls
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
    public static class CreateDomainRequestTlsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDomainRequestTls value)
        {
            return value switch
            {
                CreateDomainRequestTls.Enforced => "enforced",
                CreateDomainRequestTls.Opportunistic => "opportunistic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDomainRequestTls? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CreateDomainRequestTls.Enforced,
                "opportunistic" => CreateDomainRequestTls.Opportunistic,
                _ => null,
            };
        }
    }
}