
#nullable enable

namespace Resend
{
    /// <summary>
    /// The status of the email.<br/>
    /// Example: delivered
    /// </summary>
    public enum EmailLastEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Bounced,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
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
        DeliveryDelayed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Opened,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
        /// <summary>
        /// 
        /// </summary>
        Sent,
        /// <summary>
        /// 
        /// </summary>
        Suppressed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailLastEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailLastEvent value)
        {
            return value switch
            {
                EmailLastEvent.Bounced => "bounced",
                EmailLastEvent.Canceled => "canceled",
                EmailLastEvent.Clicked => "clicked",
                EmailLastEvent.Complained => "complained",
                EmailLastEvent.Delivered => "delivered",
                EmailLastEvent.DeliveryDelayed => "delivery_delayed",
                EmailLastEvent.Failed => "failed",
                EmailLastEvent.Opened => "opened",
                EmailLastEvent.Queued => "queued",
                EmailLastEvent.Scheduled => "scheduled",
                EmailLastEvent.Sent => "sent",
                EmailLastEvent.Suppressed => "suppressed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailLastEvent? ToEnum(string value)
        {
            return value switch
            {
                "bounced" => EmailLastEvent.Bounced,
                "canceled" => EmailLastEvent.Canceled,
                "clicked" => EmailLastEvent.Clicked,
                "complained" => EmailLastEvent.Complained,
                "delivered" => EmailLastEvent.Delivered,
                "delivery_delayed" => EmailLastEvent.DeliveryDelayed,
                "failed" => EmailLastEvent.Failed,
                "opened" => EmailLastEvent.Opened,
                "queued" => EmailLastEvent.Queued,
                "scheduled" => EmailLastEvent.Scheduled,
                "sent" => EmailLastEvent.Sent,
                "suppressed" => EmailLastEvent.Suppressed,
                _ => null,
            };
        }
    }
}