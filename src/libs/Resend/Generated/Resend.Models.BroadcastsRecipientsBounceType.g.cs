
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum BroadcastsRecipientsBounceType
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
    public static class BroadcastsRecipientsBounceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BroadcastsRecipientsBounceType value)
        {
            return value switch
            {
                BroadcastsRecipientsBounceType.Permanent => "permanent",
                BroadcastsRecipientsBounceType.Transient => "transient",
                BroadcastsRecipientsBounceType.Undetermined => "undetermined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BroadcastsRecipientsBounceType? ToEnum(string value)
        {
            return value switch
            {
                "permanent" => BroadcastsRecipientsBounceType.Permanent,
                "transient" => BroadcastsRecipientsBounceType.Transient,
                "undetermined" => BroadcastsRecipientsBounceType.Undetermined,
                _ => null,
            };
        }
    }
}