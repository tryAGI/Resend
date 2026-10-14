
#nullable enable

namespace Resend
{
    /// <summary>
    /// How the attachment should be displayed.<br/>
    /// Example: attachment
    /// </summary>
    public enum RetrievedAttachmentContentDisposition
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
    public static class RetrievedAttachmentContentDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievedAttachmentContentDisposition value)
        {
            return value switch
            {
                RetrievedAttachmentContentDisposition.Attachment => "attachment",
                RetrievedAttachmentContentDisposition.Inline => "inline",
                RetrievedAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievedAttachmentContentDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => RetrievedAttachmentContentDisposition.Attachment,
                "inline" => RetrievedAttachmentContentDisposition.Inline,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RetrievedAttachmentContentDisposition.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}