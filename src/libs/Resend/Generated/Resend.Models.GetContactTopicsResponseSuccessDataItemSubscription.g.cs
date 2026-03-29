
#nullable enable

namespace Resend
{
    /// <summary>
    /// The subscription status for this topic.
    /// </summary>
    public enum GetContactTopicsResponseSuccessDataItemSubscription
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
    public static class GetContactTopicsResponseSuccessDataItemSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactTopicsResponseSuccessDataItemSubscription value)
        {
            return value switch
            {
                GetContactTopicsResponseSuccessDataItemSubscription.OptIn => "opt_in",
                GetContactTopicsResponseSuccessDataItemSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactTopicsResponseSuccessDataItemSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => GetContactTopicsResponseSuccessDataItemSubscription.OptIn,
                "opt_out" => GetContactTopicsResponseSuccessDataItemSubscription.OptOut,
                _ => null,
            };
        }
    }
}