
#nullable enable

namespace Resend
{
    /// <summary>
    /// The delivery status of the event for this webhook.<br/>
    /// Example: success
    /// </summary>
    public enum ListWebhookEventsResponseDataItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Attempting,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWebhookEventsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWebhookEventsResponseDataItemStatus value)
        {
            return value switch
            {
                ListWebhookEventsResponseDataItemStatus.Attempting => "attempting",
                ListWebhookEventsResponseDataItemStatus.Failed => "failed",
                ListWebhookEventsResponseDataItemStatus.Pending => "pending",
                ListWebhookEventsResponseDataItemStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWebhookEventsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "attempting" => ListWebhookEventsResponseDataItemStatus.Attempting,
                "failed" => ListWebhookEventsResponseDataItemStatus.Failed,
                "pending" => ListWebhookEventsResponseDataItemStatus.Pending,
                "success" => ListWebhookEventsResponseDataItemStatus.Success,
                _ => null,
            };
        }
    }
}