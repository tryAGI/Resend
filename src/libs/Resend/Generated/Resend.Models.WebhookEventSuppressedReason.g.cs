
#nullable enable

namespace Resend
{
    /// <summary>
    /// Reason the address is suppressed.
    /// </summary>
    public enum WebhookEventSuppressedReason
    {
        /// <summary>
        /// 
        /// </summary>
        PreviousBounce,
        /// <summary>
        /// 
        /// </summary>
        PreviousComplaint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventSuppressedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventSuppressedReason value)
        {
            return value switch
            {
                WebhookEventSuppressedReason.PreviousBounce => "previous_bounce",
                WebhookEventSuppressedReason.PreviousComplaint => "previous_complaint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventSuppressedReason? ToEnum(string value)
        {
            return value switch
            {
                "previous_bounce" => WebhookEventSuppressedReason.PreviousBounce,
                "previous_complaint" => WebhookEventSuppressedReason.PreviousComplaint,
                _ => null,
            };
        }
    }
}