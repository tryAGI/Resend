
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum VerifyDomainOptionsScopeItem
    {
        /// <summary>
        ///
        /// </summary>
        Forge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerifyDomainOptionsScopeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerifyDomainOptionsScopeItem value)
        {
            return value switch
            {
                VerifyDomainOptionsScopeItem.Forge => "forge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerifyDomainOptionsScopeItem? ToEnum(string value)
        {
            return value switch
            {
                "forge" => VerifyDomainOptionsScopeItem.Forge,
                _ => null,
            };
        }
    }
}