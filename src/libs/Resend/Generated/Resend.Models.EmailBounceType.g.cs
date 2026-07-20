
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of bounce, as reported by AWS SES.<br/>
    /// Example: Permanent
    /// </summary>
    public enum EmailBounceType
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
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailBounceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailBounceType value)
        {
            return value switch
            {
                EmailBounceType.Permanent => "Permanent",
                EmailBounceType.Transient => "Transient",
                EmailBounceType.Undetermined => "Undetermined",
                EmailBounceType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailBounceType? ToEnum(string value)
        {
            return value switch
            {
                "Permanent" => EmailBounceType.Permanent,
                "Transient" => EmailBounceType.Transient,
                "Undetermined" => EmailBounceType.Undetermined,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => EmailBounceType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}