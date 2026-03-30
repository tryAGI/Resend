
#nullable enable

namespace Resend
{
    /// <summary>
    /// The HTTP method used.
    /// </summary>
    public enum LogMethod
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
    public static class LogMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogMethod value)
        {
            return value switch
            {
                LogMethod.Delete => "DELETE",
                LogMethod.Get => "GET",
                LogMethod.Options => "OPTIONS",
                LogMethod.Patch => "PATCH",
                LogMethod.Post => "POST",
                LogMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => LogMethod.Delete,
                "GET" => LogMethod.Get,
                "OPTIONS" => LogMethod.Options,
                "PATCH" => LogMethod.Patch,
                "POST" => LogMethod.Post,
                "PUT" => LogMethod.Put,
                _ => null,
            };
        }
    }
}