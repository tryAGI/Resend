
#nullable enable

namespace Resend
{
    /// <summary>
    /// The HTTP method used.
    /// </summary>
    public enum LogSummaryMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogSummaryMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogSummaryMethod value)
        {
            return value switch
            {
                LogSummaryMethod.Delete => "DELETE",
                LogSummaryMethod.Get => "GET",
                LogSummaryMethod.Options => "OPTIONS",
                LogSummaryMethod.Patch => "PATCH",
                LogSummaryMethod.Post => "POST",
                LogSummaryMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogSummaryMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => LogSummaryMethod.Delete,
                "GET" => LogSummaryMethod.Get,
                "OPTIONS" => LogSummaryMethod.Options,
                "PATCH" => LogSummaryMethod.Patch,
                "POST" => LogSummaryMethod.Post,
                "PUT" => LogSummaryMethod.Put,
                _ => null,
            };
        }
    }
}