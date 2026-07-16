
#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSuppressionsOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        Complaint,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSuppressionsOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSuppressionsOrigin value)
        {
            return value switch
            {
                GetSuppressionsOrigin.Bounce => "bounce",
                GetSuppressionsOrigin.Complaint => "complaint",
                GetSuppressionsOrigin.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSuppressionsOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => GetSuppressionsOrigin.Bounce,
                "complaint" => GetSuppressionsOrigin.Complaint,
                "manual" => GetSuppressionsOrigin.Manual,
                _ => null,
            };
        }
    }
}