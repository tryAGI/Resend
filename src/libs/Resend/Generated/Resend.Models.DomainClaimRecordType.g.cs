
#nullable enable

namespace Resend
{
    /// <summary>
    /// The DNS record type. Always TXT for domain claims.<br/>
    /// Example: TXT
    /// </summary>
    public enum DomainClaimRecordType
    {
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainClaimRecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainClaimRecordType value)
        {
            return value switch
            {
                DomainClaimRecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainClaimRecordType? ToEnum(string value)
        {
            return value switch
            {
                "TXT" => DomainClaimRecordType.Txt,
                _ => null,
            };
        }
    }
}