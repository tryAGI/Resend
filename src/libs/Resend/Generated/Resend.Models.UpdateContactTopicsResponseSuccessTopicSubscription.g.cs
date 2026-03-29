
#nullable enable

namespace Resend
{
    /// <summary>
    /// The subscription status.
    /// </summary>
    public enum UpdateContactTopicsResponseSuccessTopicSubscription
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
    public static class UpdateContactTopicsResponseSuccessTopicSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateContactTopicsResponseSuccessTopicSubscription value)
        {
            return value switch
            {
                UpdateContactTopicsResponseSuccessTopicSubscription.OptIn => "opt_in",
                UpdateContactTopicsResponseSuccessTopicSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateContactTopicsResponseSuccessTopicSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => UpdateContactTopicsResponseSuccessTopicSubscription.OptIn,
                "opt_out" => UpdateContactTopicsResponseSuccessTopicSubscription.OptOut,
                _ => null,
            };
        }
    }
}