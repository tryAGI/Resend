
#nullable enable

namespace Resend
{
    /// <summary>
    /// The subtype of the bounce, as reported by AWS SES.<br/>
    /// Example: General
    /// </summary>
    public enum EmailBounceSubType
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
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailBounceSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailBounceSubType value)
        {
            return value switch
            {
                EmailBounceSubType.AttachmentRejected => "AttachmentRejected",
                EmailBounceSubType.ContentRejected => "ContentRejected",
                EmailBounceSubType.General => "General",
                EmailBounceSubType.MailboxFull => "MailboxFull",
                EmailBounceSubType.MessageTooLarge => "MessageTooLarge",
                EmailBounceSubType.NoEmail => "NoEmail",
                EmailBounceSubType.Undetermined => "Undetermined",
                EmailBounceSubType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailBounceSubType? ToEnum(string value)
        {
            return value switch
            {
                "AttachmentRejected" => EmailBounceSubType.AttachmentRejected,
                "ContentRejected" => EmailBounceSubType.ContentRejected,
                "General" => EmailBounceSubType.General,
                "MailboxFull" => EmailBounceSubType.MailboxFull,
                "MessageTooLarge" => EmailBounceSubType.MessageTooLarge,
                "NoEmail" => EmailBounceSubType.NoEmail,
                "Undetermined" => EmailBounceSubType.Undetermined,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => EmailBounceSubType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}