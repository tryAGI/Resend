#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookEventSuppressedReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.WebhookEventSuppressedReason>
    {
        /// <inheritdoc />
        public override global::Resend.WebhookEventSuppressedReason Read(
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
                        return global::Resend.WebhookEventSuppressedReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.WebhookEventSuppressedReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.WebhookEventSuppressedReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.WebhookEventSuppressedReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.WebhookEventSuppressedReasonExtensions.ToValueString(value));
        }
    }
}
