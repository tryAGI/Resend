#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateInboxAgentOptionsEnabledActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.UpdateInboxAgentOptionsEnabledAction?>
    {
        /// <inheritdoc />
        public override global::Resend.UpdateInboxAgentOptionsEnabledAction? Read(
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
                        return global::Resend.UpdateInboxAgentOptionsEnabledActionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.UpdateInboxAgentOptionsEnabledAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.UpdateInboxAgentOptionsEnabledAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.UpdateInboxAgentOptionsEnabledAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.UpdateInboxAgentOptionsEnabledActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
