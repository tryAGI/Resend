
#nullable enable

namespace Resend
{
    /// <summary>
    /// DNS record type.
    /// </summary>
    public enum WebhookDomainRecordType
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
    public static class WebhookDomainRecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDomainRecordType value)
        {
            return value switch
            {
                WebhookDomainRecordType.Caa => "CAA",
                WebhookDomainRecordType.Cname => "CNAME",
                WebhookDomainRecordType.Mx => "MX",
                WebhookDomainRecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDomainRecordType? ToEnum(string value)
        {
            return value switch
            {
                "CAA" => WebhookDomainRecordType.Caa,
                "CNAME" => WebhookDomainRecordType.Cname,
                "MX" => WebhookDomainRecordType.Mx,
                "TXT" => WebhookDomainRecordType.Txt,
                _ => null,
            };
        }
    }
}