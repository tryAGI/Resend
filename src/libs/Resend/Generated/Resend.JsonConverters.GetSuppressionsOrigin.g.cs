#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSuppressionsOriginJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.GetSuppressionsOrigin>
    {
        /// <inheritdoc />
        public override global::Resend.GetSuppressionsOrigin Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Resend.GetSuppressionsOriginExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.GetSuppressionsOrigin)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.GetSuppressionsOrigin);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.GetSuppressionsOrigin value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.GetSuppressionsOriginExtensions.ToValueString(value));
        }
    }
}
