
#nullable enable

namespace Resend
{
    /// <summary>
    /// The visibility of the topic.
    /// </summary>
    public enum ListTopicsResponseSuccessDataItemVisibility
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
    public static class ListTopicsResponseSuccessDataItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTopicsResponseSuccessDataItemVisibility value)
        {
            return value switch
            {
                ListTopicsResponseSuccessDataItemVisibility.Private => "private",
                ListTopicsResponseSuccessDataItemVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTopicsResponseSuccessDataItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ListTopicsResponseSuccessDataItemVisibility.Private,
                "public" => ListTopicsResponseSuccessDataItemVisibility.Public,
                _ => null,
            };
        }
    }
}