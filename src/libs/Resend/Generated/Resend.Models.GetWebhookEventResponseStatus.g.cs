
#nullable enable

namespace Resend
{
    /// <summary>
    /// The delivery status of the event for this webhook.<br/>
    /// Example: attempting
    /// </summary>
    public enum GetWebhookEventResponseStatus
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
    public static class GetWebhookEventResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookEventResponseStatus value)
        {
            return value switch
            {
                GetWebhookEventResponseStatus.Attempting => "attempting",
                GetWebhookEventResponseStatus.Failed => "failed",
                GetWebhookEventResponseStatus.Pending => "pending",
                GetWebhookEventResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookEventResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "attempting" => GetWebhookEventResponseStatus.Attempting,
                "failed" => GetWebhookEventResponseStatus.Failed,
                "pending" => GetWebhookEventResponseStatus.Pending,
                "success" => GetWebhookEventResponseStatus.Success,
                _ => null,
            };
        }
    }
}