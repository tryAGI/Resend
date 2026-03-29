
#nullable enable

namespace Resend
{
    /// <summary>
    /// The visibility of the topic.
    /// </summary>
    public enum GetTopicResponseSuccessVisibility
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
    public static class GetTopicResponseSuccessVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTopicResponseSuccessVisibility value)
        {
            return value switch
            {
                GetTopicResponseSuccessVisibility.Private => "private",
                GetTopicResponseSuccessVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTopicResponseSuccessVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetTopicResponseSuccessVisibility.Private,
                "public" => GetTopicResponseSuccessVisibility.Public,
                _ => null,
            };
        }
    }
}