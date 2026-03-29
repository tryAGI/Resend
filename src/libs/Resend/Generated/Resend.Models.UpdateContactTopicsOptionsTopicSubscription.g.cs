
#nullable enable

namespace Resend
{
    /// <summary>
    /// The subscription status (opt_in or opt_out).
    /// </summary>
    public enum UpdateContactTopicsOptionsTopicSubscription
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
    public static class UpdateContactTopicsOptionsTopicSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateContactTopicsOptionsTopicSubscription value)
        {
            return value switch
            {
                UpdateContactTopicsOptionsTopicSubscription.OptIn => "opt_in",
                UpdateContactTopicsOptionsTopicSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateContactTopicsOptionsTopicSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => UpdateContactTopicsOptionsTopicSubscription.OptIn,
                "opt_out" => UpdateContactTopicsOptionsTopicSubscription.OptOut,
                _ => null,
            };
        }
    }
}