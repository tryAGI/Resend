
#nullable enable

namespace Resend
{
    /// <summary>
    /// Origin of the suppression.<br/>
    /// Example: manual
    /// </summary>
    public enum ListSuppressionsResponseSuccessDataItemOrigin
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
    public static class ListSuppressionsResponseSuccessDataItemOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSuppressionsResponseSuccessDataItemOrigin value)
        {
            return value switch
            {
                ListSuppressionsResponseSuccessDataItemOrigin.Bounce => "bounce",
                ListSuppressionsResponseSuccessDataItemOrigin.Complaint => "complaint",
                ListSuppressionsResponseSuccessDataItemOrigin.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSuppressionsResponseSuccessDataItemOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => ListSuppressionsResponseSuccessDataItemOrigin.Bounce,
                "complaint" => ListSuppressionsResponseSuccessDataItemOrigin.Complaint,
                "manual" => ListSuppressionsResponseSuccessDataItemOrigin.Manual,
                _ => null,
            };
        }
    }
}