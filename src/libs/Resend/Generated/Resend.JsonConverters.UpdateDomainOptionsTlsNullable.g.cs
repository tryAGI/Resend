#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDomainOptionsTlsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.UpdateDomainOptionsTls?>
    {
        /// <inheritdoc />
        public override global::Resend.UpdateDomainOptionsTls? Read(
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
                        return global::Resend.UpdateDomainOptionsTlsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.UpdateDomainOptionsTls)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.UpdateDomainOptionsTls?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.UpdateDomainOptionsTls? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.UpdateDomainOptionsTlsExtensions.ToValueString(value.Value));
            }
        }
    }
}
