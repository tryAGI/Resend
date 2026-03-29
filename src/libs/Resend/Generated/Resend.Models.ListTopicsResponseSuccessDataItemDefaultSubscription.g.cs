
#nullable enable

namespace Resend
{
    /// <summary>
    /// The default subscription status for the topic.
    /// </summary>
    public enum ListTopicsResponseSuccessDataItemDefaultSubscription
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
    public static class ListTopicsResponseSuccessDataItemDefaultSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTopicsResponseSuccessDataItemDefaultSubscription value)
        {
            return value switch
            {
                ListTopicsResponseSuccessDataItemDefaultSubscription.OptIn => "opt_in",
                ListTopicsResponseSuccessDataItemDefaultSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTopicsResponseSuccessDataItemDefaultSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => ListTopicsResponseSuccessDataItemDefaultSubscription.OptIn,
                "opt_out" => ListTopicsResponseSuccessDataItemDefaultSubscription.OptOut,
                _ => null,
            };
        }
    }
}