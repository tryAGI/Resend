
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of record (SPF for sending, DKIM for sending, Receiving for inbound emails, Tracking &amp; TrackingCAA for click and open tracking).
    /// </summary>
    public enum DomainRecordRecord
    {
        /// <summary>
        /// 
        /// </summary>
        Dkim,
        /// <summary>
        /// 
        /// </summary>
        Receiving,
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
    public static class DomainRecordRecordExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainRecordRecord value)
        {
            return value switch
            {
                DomainRecordRecord.Dkim => "DKIM",
                DomainRecordRecord.Receiving => "Receiving",
                DomainRecordRecord.Spf => "SPF",
                DomainRecordRecord.Tracking => "Tracking",
                DomainRecordRecord.TrackingCAA => "TrackingCAA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainRecordRecord? ToEnum(string value)
        {
            return value switch
            {
                "DKIM" => DomainRecordRecord.Dkim,
                "Receiving" => DomainRecordRecord.Receiving,
                "SPF" => DomainRecordRecord.Spf,
                "Tracking" => DomainRecordRecord.Tracking,
                "TrackingCAA" => DomainRecordRecord.TrackingCAA,
                _ => null,
            };
        }
    }
}