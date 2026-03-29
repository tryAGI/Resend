
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of the variable.
    /// </summary>
    public enum TemplateVariableInputType
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
    public static class TemplateVariableInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateVariableInputType value)
        {
            return value switch
            {
                TemplateVariableInputType.Boolean => "boolean",
                TemplateVariableInputType.List => "list",
                TemplateVariableInputType.Number => "number",
                TemplateVariableInputType.Object => "object",
                TemplateVariableInputType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateVariableInputType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TemplateVariableInputType.Boolean,
                "list" => TemplateVariableInputType.List,
                "number" => TemplateVariableInputType.Number,
                "object" => TemplateVariableInputType.Object,
                "string" => TemplateVariableInputType.String,
                _ => null,
            };
        }
    }
}