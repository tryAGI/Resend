#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class VerifyDomainOptionsScopeItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.VerifyDomainOptionsScopeItem?>
    {
        /// <inheritdoc />
        public override global::Resend.VerifyDomainOptionsScopeItem? Read(
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
                        return global::Resend.VerifyDomainOptionsScopeItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.VerifyDomainOptionsScopeItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.VerifyDomainOptionsScopeItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.VerifyDomainOptionsScopeItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.VerifyDomainOptionsScopeItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
