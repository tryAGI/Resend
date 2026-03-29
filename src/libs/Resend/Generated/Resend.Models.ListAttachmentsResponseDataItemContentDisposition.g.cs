
#nullable enable

namespace Resend
{
    /// <summary>
    /// How the attachment should be displayed.<br/>
    /// Example: attachment
    /// </summary>
    public enum ListAttachmentsResponseDataItemContentDisposition
    {
        /// <summary>
        /// 
        /// </summary>
        Attachment,
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAttachmentsResponseDataItemContentDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAttachmentsResponseDataItemContentDisposition value)
        {
            return value switch
            {
                ListAttachmentsResponseDataItemContentDisposition.Attachment => "attachment",
                ListAttachmentsResponseDataItemContentDisposition.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAttachmentsResponseDataItemContentDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attachment" => ListAttachmentsResponseDataItemContentDisposition.Attachment,
                "inline" => ListAttachmentsResponseDataItemContentDisposition.Inline,
                _ => null,
            };
        }
    }
}