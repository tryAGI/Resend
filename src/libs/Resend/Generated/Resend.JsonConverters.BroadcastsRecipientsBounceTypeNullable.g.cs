#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class BroadcastsRecipientsBounceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.BroadcastsRecipientsBounceType?>
    {
        /// <inheritdoc />
        public override global::Resend.BroadcastsRecipientsBounceType? Read(
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
                        return global::Resend.BroadcastsRecipientsBounceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.BroadcastsRecipientsBounceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.BroadcastsRecipientsBounceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.BroadcastsRecipientsBounceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.BroadcastsRecipientsBounceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
