#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListTopicsResponseSuccessDataItemDefaultSubscriptionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?>
    {
        /// <inheritdoc />
        public override global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Read(
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
                        return global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscriptionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscriptionExtensions.ToValueString(value.Value));
            }
        }
    }
}
