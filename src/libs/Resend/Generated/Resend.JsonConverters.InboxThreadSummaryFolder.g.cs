#nullable enable

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public sealed class InboxThreadSummaryFolderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.InboxThreadSummaryFolder>
    {
        /// <inheritdoc />
        public override global::Resend.InboxThreadSummaryFolder Read(
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
                        return global::Resend.InboxThreadSummaryFolderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Resend.InboxThreadSummaryFolder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Resend.InboxThreadSummaryFolder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.InboxThreadSummaryFolder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Resend.InboxThreadSummaryFolderExtensions.ToValueString(value));
        }
    }
}
