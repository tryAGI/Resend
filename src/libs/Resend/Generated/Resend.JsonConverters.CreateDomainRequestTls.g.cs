#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDomainRequestTlsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.CreateDomainRequestTls>
    {
        /// <inheritdoc />
        public override global::Resend.CreateDomainRequestTls Read(
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
                        return global::Resend.CreateDomainRequestTlsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.CreateDomainRequestTls)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.CreateDomainRequestTls);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.CreateDomainRequestTls value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.CreateDomainRequestTlsExtensions.ToValueString(value));
        }
    }
}
