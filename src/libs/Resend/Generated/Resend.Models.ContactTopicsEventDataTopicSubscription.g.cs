
#nullable enable

namespace Resend
{
    /// <summary>
    /// The new subscription status for this topic.
    /// </summary>
    public enum ContactTopicsEventDataTopicSubscription
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
    public static class ContactTopicsEventDataTopicSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactTopicsEventDataTopicSubscription value)
        {
            return value switch
            {
                ContactTopicsEventDataTopicSubscription.OptIn => "opt_in",
                ContactTopicsEventDataTopicSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactTopicsEventDataTopicSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => ContactTopicsEventDataTopicSubscription.OptIn,
                "opt_out" => ContactTopicsEventDataTopicSubscription.OptOut,
                _ => null,
            };
        }
    }
}