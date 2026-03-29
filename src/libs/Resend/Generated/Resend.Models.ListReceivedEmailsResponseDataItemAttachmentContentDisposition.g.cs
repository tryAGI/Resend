
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
                _ => null,
            };
        }
    }
}