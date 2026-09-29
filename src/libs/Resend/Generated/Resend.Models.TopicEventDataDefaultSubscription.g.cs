
#nullable enable

namespace Resend
{
    /// <summary>
    /// The default subscription status for the topic.
    /// </summary>
    public enum TopicEventDataDefaultSubscription
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
    public static class TopicEventDataDefaultSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicEventDataDefaultSubscription value)
        {
            return value switch
            {
                TopicEventDataDefaultSubscription.OptIn => "opt_in",
                TopicEventDataDefaultSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicEventDataDefaultSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => TopicEventDataDefaultSubscription.OptIn,
                "opt_out" => TopicEventDataDefaultSubscription.OptOut,
                _ => null,
            };
        }
    }
}