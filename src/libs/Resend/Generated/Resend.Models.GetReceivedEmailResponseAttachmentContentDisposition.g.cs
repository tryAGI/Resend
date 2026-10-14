
#nullable enable

namespace Resend
{
    /// <summary>
    /// How the attachment should be displayed.
    /// </summary>
    public enum GetReceivedEmailResponseAttachmentContentDisposition
    {
        /// <summary>
        ///
        /// </summary>
        Attachment,
        /// <summary>
        ///
        /// </summary>
        Inline,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetReceivedEmailResponseAttachmentContentDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetReceivedEmailResponseAttachmentContentDisposition value)
        {
            return value switch
            {
                GetReceivedEmailResponseAttachmentContentDisposition.Attachment => "attachment",
                GetReceivedEmailResponseAttachmentContentDisposition.Inline => "inline",
                GetReceivedEmailResponseAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetReceivedEmailResponseAttachmentContentDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => GetReceivedEmailResponseAttachmentContentDisposition.Attachment,
                "inline" => GetReceivedEmailResponseAttachmentContentDisposition.Inline,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => GetReceivedEmailResponseAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}