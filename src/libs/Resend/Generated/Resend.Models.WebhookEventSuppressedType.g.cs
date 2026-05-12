
#nullable enable

namespace Resend
{
    /// <summary>
    /// Suppression type.
    /// </summary>
    public enum WebhookEventSuppressedType
    {
        /// <summary>
        /// 
        /// </summary>
        OnAccountSuppressionList,
        /// <summary>
        /// 
        /// </summary>
        Suppressed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventSuppressedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventSuppressedType value)
        {
            return value switch
            {
                WebhookEventSuppressedType.OnAccountSuppressionList => "OnAccountSuppressionList",
                WebhookEventSuppressedType.Suppressed => "Suppressed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventSuppressedType? ToEnum(string value)
        {
            return value switch
            {
                "OnAccountSuppressionList" => WebhookEventSuppressedType.OnAccountSuppressionList,
                "Suppressed" => WebhookEventSuppressedType.Suppressed,
                _ => null,
            };
        }
    }
}