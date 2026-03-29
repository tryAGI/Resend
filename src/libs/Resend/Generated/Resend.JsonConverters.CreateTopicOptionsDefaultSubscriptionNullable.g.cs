#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTopicOptionsDefaultSubscriptionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.CreateTopicOptionsDefaultSubscription?>
    {
        /// <inheritdoc />
        public override global::Resend.CreateTopicOptionsDefaultSubscription? Read(
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
                        return global::Resend.CreateTopicOptionsDefaultSubscriptionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.CreateTopicOptionsDefaultSubscription)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.CreateTopicOptionsDefaultSubscription?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.CreateTopicOptionsDefaultSubscription? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.CreateTopicOptionsDefaultSubscriptionExtensions.ToValueString(value.Value));
            }
        }
    }
}
