
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of bounce. Only present when `type` is `bounced`.
    /// </summary>
    public enum ListBroadcastRecipientsResponseSuccessDataItemBounceType
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
    public static class ListBroadcastRecipientsResponseSuccessDataItemBounceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBroadcastRecipientsResponseSuccessDataItemBounceType value)
        {
            return value switch
            {
                ListBroadcastRecipientsResponseSuccessDataItemBounceType.Permanent => "permanent",
                ListBroadcastRecipientsResponseSuccessDataItemBounceType.Transient => "transient",
                ListBroadcastRecipientsResponseSuccessDataItemBounceType.Undetermined => "undetermined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBroadcastRecipientsResponseSuccessDataItemBounceType? ToEnum(string value)
        {
            return value switch
            {
                "permanent" => ListBroadcastRecipientsResponseSuccessDataItemBounceType.Permanent,
                "transient" => ListBroadcastRecipientsResponseSuccessDataItemBounceType.Transient,
                "undetermined" => ListBroadcastRecipientsResponseSuccessDataItemBounceType.Undetermined,
                _ => null,
            };
        }
    }
}