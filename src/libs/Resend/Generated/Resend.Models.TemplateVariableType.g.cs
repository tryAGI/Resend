
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of the variable.
    /// </summary>
    public enum TemplateVariableType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateVariableType value)
        {
            return value switch
            {
                TemplateVariableType.Boolean => "boolean",
                TemplateVariableType.List => "list",
                TemplateVariableType.Number => "number",
                TemplateVariableType.Object => "object",
                TemplateVariableType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateVariableType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TemplateVariableType.Boolean,
                "list" => TemplateVariableType.List,
                "number" => TemplateVariableType.Number,
                "object" => TemplateVariableType.Object,
                "string" => TemplateVariableType.String,
                _ => null,
            };
        }
    }
}