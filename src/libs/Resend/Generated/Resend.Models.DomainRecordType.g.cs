
#nullable enable

namespace Resend
{
    /// <summary>
    /// The DNS record type.
    /// </summary>
    public enum DomainRecordType
    {
        /// <summary>
        /// 
        /// </summary>
        Caa,
        /// <summary>
        /// 
        /// </summary>
        Cname,
        /// <summary>
        /// 
        /// </summary>
        Mx,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainRecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainRecordType value)
        {
            return value switch
            {
                DomainRecordType.Caa => "CAA",
                DomainRecordType.Cname => "CNAME",
                DomainRecordType.Mx => "MX",
                DomainRecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainRecordType? ToEnum(string value)
        {
            return value switch
            {
                "CAA" => DomainRecordType.Caa,
                "CNAME" => DomainRecordType.Cname,
                "MX" => DomainRecordType.Mx,
                "TXT" => DomainRecordType.Txt,
                _ => null,
            };
        }
    }
}