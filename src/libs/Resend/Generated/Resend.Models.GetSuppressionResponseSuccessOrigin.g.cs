
#nullable enable

namespace Resend
{
    /// <summary>
    /// Origin of the suppression.<br/>
    /// Example: manual
    /// </summary>
    public enum GetSuppressionResponseSuccessOrigin
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
    public static class GetSuppressionResponseSuccessOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSuppressionResponseSuccessOrigin value)
        {
            return value switch
            {
                GetSuppressionResponseSuccessOrigin.Bounce => "bounce",
                GetSuppressionResponseSuccessOrigin.Complaint => "complaint",
                GetSuppressionResponseSuccessOrigin.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSuppressionResponseSuccessOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => GetSuppressionResponseSuccessOrigin.Bounce,
                "complaint" => GetSuppressionResponseSuccessOrigin.Complaint,
                "manual" => GetSuppressionResponseSuccessOrigin.Manual,
                _ => null,
            };
        }
    }
}