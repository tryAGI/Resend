#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateInboxAgentOptionsToneJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.UpdateInboxAgentOptionsTone>
    {
        /// <inheritdoc />
        public override global::Resend.UpdateInboxAgentOptionsTone Read(
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
                        return global::Resend.UpdateInboxAgentOptionsToneExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.UpdateInboxAgentOptionsTone)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.UpdateInboxAgentOptionsTone);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.UpdateInboxAgentOptionsTone value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.UpdateInboxAgentOptionsToneExtensions.ToValueString(value));
        }
    }
}
