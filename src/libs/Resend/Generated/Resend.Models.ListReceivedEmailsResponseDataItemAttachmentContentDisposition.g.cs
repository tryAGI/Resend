
#nullable enable

namespace Resend
{
    /// <summary>
    /// How the attachment should be displayed.
    /// </summary>
    public enum ListReceivedEmailsResponseDataItemAttachmentContentDisposition
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
    public static class ListReceivedEmailsResponseDataItemAttachmentContentDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReceivedEmailsResponseDataItemAttachmentContentDisposition value)
        {
            return value switch
            {
                ListReceivedEmailsResponseDataItemAttachmentContentDisposition.Attachment => "attachment",
                ListReceivedEmailsResponseDataItemAttachmentContentDisposition.Inline => "inline",
                ListReceivedEmailsResponseDataItemAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReceivedEmailsResponseDataItemAttachmentContentDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => ListReceivedEmailsResponseDataItemAttachmentContentDisposition.Attachment,
                "inline" => ListReceivedEmailsResponseDataItemAttachmentContentDisposition.Inline,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => ListReceivedEmailsResponseDataItemAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}