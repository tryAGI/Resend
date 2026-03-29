
#nullable enable

namespace Resend
{
    /// <summary>
    /// The visibility of the topic.
    /// </summary>
    public enum UpdateTopicOptionsVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTopicOptionsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTopicOptionsVisibility value)
        {
            return value switch
            {
                UpdateTopicOptionsVisibility.Private => "private",
                UpdateTopicOptionsVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTopicOptionsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateTopicOptionsVisibility.Private,
                "public" => UpdateTopicOptionsVisibility.Public,
                _ => null,
            };
        }
    }
}