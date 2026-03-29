
#nullable enable

namespace Resend
{
    /// <summary>
    /// The visibility of the topic. Public topics are visible to all contacts on the unsubscribe page. Private topics are only visible to opted-in contacts.<br/>
    /// Default Value: private
    /// </summary>
    public enum CreateTopicOptionsVisibility
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
    public static class CreateTopicOptionsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTopicOptionsVisibility value)
        {
            return value switch
            {
                CreateTopicOptionsVisibility.Private => "private",
                CreateTopicOptionsVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTopicOptionsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateTopicOptionsVisibility.Private,
                "public" => CreateTopicOptionsVisibility.Public,
                _ => null,
            };
        }
    }
}