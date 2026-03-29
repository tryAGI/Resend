#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListTopicsResponseSuccessDataItemVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.ListTopicsResponseSuccessDataItemVisibility?>
    {
        /// <inheritdoc />
        public override global::Resend.ListTopicsResponseSuccessDataItemVisibility? Read(
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
                        return global::Resend.ListTopicsResponseSuccessDataItemVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.ListTopicsResponseSuccessDataItemVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.ListTopicsResponseSuccessDataItemVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.ListTopicsResponseSuccessDataItemVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.ListTopicsResponseSuccessDataItemVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
