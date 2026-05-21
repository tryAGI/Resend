
#nullable enable

namespace Resend
{
    /// <summary>
    /// Bounce sub-type.
    /// </summary>
    public enum WebhookEventBounceSubType
    {
        /// <summary>
        /// 
        /// </summary>
        AttachmentRejected,
        /// <summary>
        /// 
        /// </summary>
        ContentRejected,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        MailboxFull,
        /// <summary>
        /// 
        /// </summary>
        MessageTooLarge,
        /// <summary>
        /// 
        /// </summary>
        NoEmail,
        /// <summary>
        /// 
        /// </summary>
        Undetermined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventBounceSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventBounceSubType value)
        {
            return value switch
            {
                WebhookEventBounceSubType.AttachmentRejected => "AttachmentRejected",
                WebhookEventBounceSubType.ContentRejected => "ContentRejected",
                WebhookEventBounceSubType.General => "General",
                WebhookEventBounceSubType.MailboxFull => "MailboxFull",
                WebhookEventBounceSubType.MessageTooLarge => "MessageTooLarge",
                WebhookEventBounceSubType.NoEmail => "NoEmail",
                WebhookEventBounceSubType.Undetermined => "Undetermined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventBounceSubType? ToEnum(string value)
        {
            return value switch
            {
                "AttachmentRejected" => WebhookEventBounceSubType.AttachmentRejected,
                "ContentRejected" => WebhookEventBounceSubType.ContentRejected,
                "General" => WebhookEventBounceSubType.General,
                "MailboxFull" => WebhookEventBounceSubType.MailboxFull,
                "MessageTooLarge" => WebhookEventBounceSubType.MessageTooLarge,
                "NoEmail" => WebhookEventBounceSubType.NoEmail,
                "Undetermined" => WebhookEventBounceSubType.Undetermined,
                _ => null,
            };
        }
    }
}