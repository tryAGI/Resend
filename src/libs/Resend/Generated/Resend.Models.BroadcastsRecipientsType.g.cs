
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum BroadcastsRecipientsType
    {
        /// <summary>
        /// 
        /// </summary>
        Bounced,
        /// <summary>
        /// 
        /// </summary>
        Clicked,
        /// <summary>
        /// 
        /// </summary>
        Complained,
        /// <summary>
        /// 
        /// </summary>
        Delivered,
        /// <summary>
        /// 
        /// </summary>
        Opened,
        /// <summary>
        /// 
        /// </summary>
        Sent,
        /// <summary>
        /// 
        /// </summary>
        Suppressed,
        /// <summary>
        /// 
        /// </summary>
        Unsubscribed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BroadcastsRecipientsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BroadcastsRecipientsType value)
        {
            return value switch
            {
                BroadcastsRecipientsType.Bounced => "bounced",
                BroadcastsRecipientsType.Clicked => "clicked",
                BroadcastsRecipientsType.Complained => "complained",
                BroadcastsRecipientsType.Delivered => "delivered",
                BroadcastsRecipientsType.Opened => "opened",
                BroadcastsRecipientsType.Sent => "sent",
                BroadcastsRecipientsType.Suppressed => "suppressed",
                BroadcastsRecipientsType.Unsubscribed => "unsubscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BroadcastsRecipientsType? ToEnum(string value)
        {
            return value switch
            {
                "bounced" => BroadcastsRecipientsType.Bounced,
                "clicked" => BroadcastsRecipientsType.Clicked,
                "complained" => BroadcastsRecipientsType.Complained,
                "delivered" => BroadcastsRecipientsType.Delivered,
                "opened" => BroadcastsRecipientsType.Opened,
                "sent" => BroadcastsRecipientsType.Sent,
                "suppressed" => BroadcastsRecipientsType.Suppressed,
                "unsubscribed" => BroadcastsRecipientsType.Unsubscribed,
                _ => null,
            };
        }
    }
}