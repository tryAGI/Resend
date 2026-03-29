
#nullable enable

namespace Resend
{
    /// <summary>
    /// The publication status of the template.
    /// </summary>
    public enum TemplateListItemStatus
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
    public static class TemplateListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateListItemStatus value)
        {
            return value switch
            {
                TemplateListItemStatus.Draft => "draft",
                TemplateListItemStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => TemplateListItemStatus.Draft,
                "published" => TemplateListItemStatus.Published,
                _ => null,
            };
        }
    }
}