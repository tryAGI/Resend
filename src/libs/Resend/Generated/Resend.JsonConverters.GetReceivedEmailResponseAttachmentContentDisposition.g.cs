#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetReceivedEmailResponseAttachmentContentDispositionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.GetReceivedEmailResponseAttachmentContentDisposition>
    {
        /// <inheritdoc />
        public override global::Resend.GetReceivedEmailResponseAttachmentContentDisposition Read(
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
                        return global::Resend.GetReceivedEmailResponseAttachmentContentDispositionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.GetReceivedEmailResponseAttachmentContentDisposition)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.GetReceivedEmailResponseAttachmentContentDisposition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.GetReceivedEmailResponseAttachmentContentDispositionExtensions.ToValueString(value));
        }
    }
}
