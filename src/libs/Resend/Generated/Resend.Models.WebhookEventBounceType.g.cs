
#nullable enable

namespace Resend
{
    /// <summary>
    /// Bounce type.
    /// </summary>
    public enum WebhookEventBounceType
    {
        /// <summary>
        /// 
        /// </summary>
        Permanent,
        /// <summary>
        /// 
        /// </summary>
        Transient,
        /// <summary>
        /// 
        /// </summary>
        Undetermined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventBounceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventBounceType value)
        {
            return value switch
            {
                WebhookEventBounceType.Permanent => "Permanent",
                WebhookEventBounceType.Transient => "Transient",
                WebhookEventBounceType.Undetermined => "Undetermined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventBounceType? ToEnum(string value)
        {
            return value switch
            {
                "Permanent" => WebhookEventBounceType.Permanent,
                "Transient" => WebhookEventBounceType.Transient,
                "Undetermined" => WebhookEventBounceType.Undetermined,
                _ => null,
            };
        }
    }
}