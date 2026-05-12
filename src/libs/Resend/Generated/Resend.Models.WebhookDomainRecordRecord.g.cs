
#nullable enable

namespace Resend
{
    /// <summary>
    /// The purpose of the DNS record (SPF and DKIM for sending; Receiving MX for inbound emails; Tracking and TrackingCAA for click and open tracking).
    /// </summary>
    public enum WebhookDomainRecordRecord
    {
        /// <summary>
        /// 
        /// </summary>
        Dkim,
        /// <summary>
        /// 
        /// </summary>
        ReceivingMx,
        /// <summary>
        /// 
        /// </summary>
        Spf,
        /// <summary>
        /// 
        /// </summary>
        Tracking,
        /// <summary>
        /// 
        /// </summary>
        TrackingCAA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDomainRecordRecordExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDomainRecordRecord value)
        {
            return value switch
            {
                WebhookDomainRecordRecord.Dkim => "DKIM",
                WebhookDomainRecordRecord.ReceivingMx => "Receiving MX",
                WebhookDomainRecordRecord.Spf => "SPF",
                WebhookDomainRecordRecord.Tracking => "Tracking",
                WebhookDomainRecordRecord.TrackingCAA => "TrackingCAA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDomainRecordRecord? ToEnum(string value)
        {
            return value switch
            {
                "DKIM" => WebhookDomainRecordRecord.Dkim,
                "Receiving MX" => WebhookDomainRecordRecord.ReceivingMx,
                "SPF" => WebhookDomainRecordRecord.Spf,
                "Tracking" => WebhookDomainRecordRecord.Tracking,
                "TrackingCAA" => WebhookDomainRecordRecord.TrackingCAA,
                _ => null,
            };
        }
    }
}