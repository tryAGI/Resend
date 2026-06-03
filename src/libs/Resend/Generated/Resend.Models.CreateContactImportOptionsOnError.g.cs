
#nullable enable

namespace Resend
{
    /// <summary>
    /// Strategy to use when an imported row fails validation.<br/>
    /// Default Value: continue<br/>
    /// Example: continue
    /// </summary>
    public enum CreateContactImportOptionsOnError
    {
        /// <summary>
        /// 
        /// </summary>
        Abort,
        /// <summary>
        /// 
        /// </summary>
        Continue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContactImportOptionsOnErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContactImportOptionsOnError value)
        {
            return value switch
            {
                CreateContactImportOptionsOnError.Abort => "abort",
                CreateContactImportOptionsOnError.Continue => "continue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContactImportOptionsOnError? ToEnum(string value)
        {
            return value switch
            {
                "abort" => CreateContactImportOptionsOnError.Abort,
                "continue" => CreateContactImportOptionsOnError.Continue,
                _ => null,
            };
        }
    }
}