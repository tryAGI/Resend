
#nullable enable

namespace Resend
{
    /// <summary>
    /// The property type.
    /// </summary>
    public enum CreateContactPropertyOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContactPropertyOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContactPropertyOptionsType value)
        {
            return value switch
            {
                CreateContactPropertyOptionsType.Number => "number",
                CreateContactPropertyOptionsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContactPropertyOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "number" => CreateContactPropertyOptionsType.Number,
                "string" => CreateContactPropertyOptionsType.String,
                _ => null,
            };
        }
    }
}