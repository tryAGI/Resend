
#nullable enable

namespace Resend
{
    /// <summary>
    /// Origin of the suppression.
    /// </summary>
    public enum SuppressionEventDataOrigin
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
    public static class SuppressionEventDataOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuppressionEventDataOrigin value)
        {
            return value switch
            {
                SuppressionEventDataOrigin.Bounce => "bounce",
                SuppressionEventDataOrigin.Complaint => "complaint",
                SuppressionEventDataOrigin.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuppressionEventDataOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => SuppressionEventDataOrigin.Bounce,
                "complaint" => SuppressionEventDataOrigin.Complaint,
                "manual" => SuppressionEventDataOrigin.Manual,
                _ => null,
            };
        }
    }
}