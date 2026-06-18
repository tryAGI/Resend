#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDomainClaimRequestRegionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.CreateDomainClaimRequestRegion?>
    {
        /// <inheritdoc />
        public override global::Resend.CreateDomainClaimRequestRegion? Read(
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
                        return global::Resend.CreateDomainClaimRequestRegionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.CreateDomainClaimRequestRegion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.CreateDomainClaimRequestRegion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.CreateDomainClaimRequestRegion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Resend.CreateDomainClaimRequestRegionExtensions.ToValueString(value.Value));
            }
        }
    }
}
