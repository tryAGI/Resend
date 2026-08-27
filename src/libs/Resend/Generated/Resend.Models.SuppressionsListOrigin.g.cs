
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public enum SuppressionsListOrigin
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
    public static class SuppressionsListOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuppressionsListOrigin value)
        {
            return value switch
            {
                SuppressionsListOrigin.Bounce => "bounce",
                SuppressionsListOrigin.Complaint => "complaint",
                SuppressionsListOrigin.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuppressionsListOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => SuppressionsListOrigin.Bounce,
                "complaint" => SuppressionsListOrigin.Complaint,
                "manual" => SuppressionsListOrigin.Manual,
                _ => null,
            };
        }
    }
}