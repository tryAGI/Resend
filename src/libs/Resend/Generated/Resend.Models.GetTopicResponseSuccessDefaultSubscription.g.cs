
#nullable enable

namespace Resend
{
    /// <summary>
    /// The default subscription status for the topic.
    /// </summary>
    public enum GetTopicResponseSuccessDefaultSubscription
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
    public static class GetTopicResponseSuccessDefaultSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTopicResponseSuccessDefaultSubscription value)
        {
            return value switch
            {
                GetTopicResponseSuccessDefaultSubscription.OptIn => "opt_in",
                GetTopicResponseSuccessDefaultSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTopicResponseSuccessDefaultSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => GetTopicResponseSuccessDefaultSubscription.OptIn,
                "opt_out" => GetTopicResponseSuccessDefaultSubscription.OptOut,
                _ => null,
            };
        }
    }
}