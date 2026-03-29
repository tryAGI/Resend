
#nullable enable

namespace Resend
{
    /// <summary>
    /// The subscription status for this topic.
    /// </summary>
    public enum CreateContactOptionsTopicSubscription
    {
        /// <summary>
        /// 
        /// </summary>
        OptIn,
        /// <summary>
        /// 
        /// </summary>
        OptOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContactOptionsTopicSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContactOptionsTopicSubscription value)
        {
            return value switch
            {
                CreateContactOptionsTopicSubscription.OptIn => "opt_in",
                CreateContactOptionsTopicSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContactOptionsTopicSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => CreateContactOptionsTopicSubscription.OptIn,
                "opt_out" => CreateContactOptionsTopicSubscription.OptOut,
                _ => null,
            };
        }
    }
}