
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum EmailsMetricsMetric
    {
        /// <summary>
        ///
        /// </summary>
        BounceRate,
        /// <summary>
        ///
        /// </summary>
        Bounced,
        /// <summary>
        ///
        /// </summary>
        BouncedPermanent,
        /// <summary>
        ///
        /// </summary>
        BouncedTransient,
        /// <summary>
        ///
        /// </summary>
        BouncedUndetermined,
        /// <summary>
        ///
        /// </summary>
        ClickRate,
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
        ComplaintRate,
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
        DeliveryRate,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        OpenRate,
        /// <summary>
        ///
        /// </summary>
        Opened,
        /// <summary>
        ///
        /// </summary>
        Received,
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
        UniqueClicked,
        /// <summary>
        ///
        /// </summary>
        UniqueOpened,
        /// <summary>
        ///
        /// </summary>
        UnsubscribeRate,
        /// <summary>
        ///
        /// </summary>
        Unsubscribed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailsMetricsMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailsMetricsMetric value)
        {
            return value switch
            {
                EmailsMetricsMetric.BounceRate => "bounce_rate",
                EmailsMetricsMetric.Bounced => "bounced",
                EmailsMetricsMetric.BouncedPermanent => "bounced_permanent",
                EmailsMetricsMetric.BouncedTransient => "bounced_transient",
                EmailsMetricsMetric.BouncedUndetermined => "bounced_undetermined",
                EmailsMetricsMetric.ClickRate => "click_rate",
                EmailsMetricsMetric.Clicked => "clicked",
                EmailsMetricsMetric.Complained => "complained",
                EmailsMetricsMetric.ComplaintRate => "complaint_rate",
                EmailsMetricsMetric.Delivered => "delivered",
                EmailsMetricsMetric.DeliveryDelayed => "delivery_delayed",
                EmailsMetricsMetric.DeliveryRate => "delivery_rate",
                EmailsMetricsMetric.Failed => "failed",
                EmailsMetricsMetric.OpenRate => "open_rate",
                EmailsMetricsMetric.Opened => "opened",
                EmailsMetricsMetric.Received => "received",
                EmailsMetricsMetric.Sent => "sent",
                EmailsMetricsMetric.Suppressed => "suppressed",
                EmailsMetricsMetric.UniqueClicked => "unique_clicked",
                EmailsMetricsMetric.UniqueOpened => "unique_opened",
                EmailsMetricsMetric.UnsubscribeRate => "unsubscribe_rate",
                EmailsMetricsMetric.Unsubscribed => "unsubscribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailsMetricsMetric? ToEnum(string value)
        {
            return value switch
            {
                "bounce_rate" => EmailsMetricsMetric.BounceRate,
                "bounced" => EmailsMetricsMetric.Bounced,
                "bounced_permanent" => EmailsMetricsMetric.BouncedPermanent,
                "bounced_transient" => EmailsMetricsMetric.BouncedTransient,
                "bounced_undetermined" => EmailsMetricsMetric.BouncedUndetermined,
                "click_rate" => EmailsMetricsMetric.ClickRate,
                "clicked" => EmailsMetricsMetric.Clicked,
                "complained" => EmailsMetricsMetric.Complained,
                "complaint_rate" => EmailsMetricsMetric.ComplaintRate,
                "delivered" => EmailsMetricsMetric.Delivered,
                "delivery_delayed" => EmailsMetricsMetric.DeliveryDelayed,
                "delivery_rate" => EmailsMetricsMetric.DeliveryRate,
                "failed" => EmailsMetricsMetric.Failed,
                "open_rate" => EmailsMetricsMetric.OpenRate,
                "opened" => EmailsMetricsMetric.Opened,
                "received" => EmailsMetricsMetric.Received,
                "sent" => EmailsMetricsMetric.Sent,
                "suppressed" => EmailsMetricsMetric.Suppressed,
                "unique_clicked" => EmailsMetricsMetric.UniqueClicked,
                "unique_opened" => EmailsMetricsMetric.UniqueOpened,
                "unsubscribe_rate" => EmailsMetricsMetric.UnsubscribeRate,
                "unsubscribed" => EmailsMetricsMetric.Unsubscribed,
                _ => null,
            };
        }
    }
}