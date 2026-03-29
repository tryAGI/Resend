
#nullable enable

namespace Resend
{
    /// <summary>
    /// The default subscription status for the topic. Cannot be changed after creation.
    /// </summary>
    public enum CreateTopicOptionsDefaultSubscription
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
    public static class CreateTopicOptionsDefaultSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTopicOptionsDefaultSubscription value)
        {
            return value switch
            {
                CreateTopicOptionsDefaultSubscription.OptIn => "opt_in",
                CreateTopicOptionsDefaultSubscription.OptOut => "opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTopicOptionsDefaultSubscription? ToEnum(string value)
        {
            return value switch
            {
                "opt_in" => CreateTopicOptionsDefaultSubscription.OptIn,
                "opt_out" => CreateTopicOptionsDefaultSubscription.OptOut,
                _ => null,
            };
        }
    }
}