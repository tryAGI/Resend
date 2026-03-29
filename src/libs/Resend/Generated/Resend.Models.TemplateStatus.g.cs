
#nullable enable

namespace Resend
{
    /// <summary>
    /// The publication status of the template.
    /// </summary>
    public enum TemplateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateStatus value)
        {
            return value switch
            {
                TemplateStatus.Draft => "draft",
                TemplateStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => TemplateStatus.Draft,
                "published" => TemplateStatus.Published,
                _ => null,
            };
        }
    }
}