
#nullable enable

namespace Resend
{
    /// <summary>
    /// Strategy to use when an imported contact already exists.<br/>
    /// Default Value: skip<br/>
    /// Example: skip
    /// </summary>
    public enum CreateContactImportOptionsOnConflict
    {
        /// <summary>
        /// 
        /// </summary>
        Skip,
        /// <summary>
        /// 
        /// </summary>
        Upsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContactImportOptionsOnConflictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContactImportOptionsOnConflict value)
        {
            return value switch
            {
                CreateContactImportOptionsOnConflict.Skip => "skip",
                CreateContactImportOptionsOnConflict.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContactImportOptionsOnConflict? ToEnum(string value)
        {
            return value switch
            {
                "skip" => CreateContactImportOptionsOnConflict.Skip,
                "upsert" => CreateContactImportOptionsOnConflict.Upsert,
                _ => null,
            };
        }
    }
}