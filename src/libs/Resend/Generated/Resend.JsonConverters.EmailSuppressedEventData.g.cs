#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend.JsonConverters
{
    /// <inheritdoc />
    public class EmailSuppressedEventDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Resend.EmailSuppressedEventData>
    {
        /// <inheritdoc />
        public override global::Resend.EmailSuppressedEventData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("broadcast_id")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("email_id")) __score0++;
            if (__jsonProps.Contains("from")) __score0++;
            if (__jsonProps.Contains("headers")) __score0++;
            if (__jsonProps.Contains("subject")) __score0++;
            if (__jsonProps.Contains("tags")) __score0++;
            if (__jsonProps.Contains("template_id")) __score0++;
            if (__jsonProps.Contains("to")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("suppressed")) __score1++;
            if (__jsonProps.Contains("suppressed.diagnosticCode")) __score1++;
            if (__jsonProps.Contains("suppressed.message")) __score1++;
            if (__jsonProps.Contains("suppressed.reason")) __score1++;
            if (__jsonProps.Contains("suppressed.type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Resend.OutboundEmailEventData? outbound = default;
            global::Resend.EmailSuppressedEventDataVariant2? emailSuppressedEventDataVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.OutboundEmailEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.OutboundEmailEventData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.OutboundEmailEventData).Name}");
                        outbound = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.EmailSuppressedEventDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.EmailSuppressedEventDataVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.EmailSuppressedEventDataVariant2).Name}");
                        emailSuppressedEventDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outbound == null && emailSuppressedEventDataVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.OutboundEmailEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.OutboundEmailEventData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.OutboundEmailEventData).Name}");
                    outbound = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (outbound == null && emailSuppressedEventDataVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.EmailSuppressedEventDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.EmailSuppressedEventDataVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.EmailSuppressedEventDataVariant2).Name}");
                    emailSuppressedEventDataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Resend.EmailSuppressedEventData(
                outbound,

                emailSuppressedEventDataVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Resend.EmailSuppressedEventData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutbound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.OutboundEmailEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.OutboundEmailEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.OutboundEmailEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Outbound!, typeInfo);
            }
            else if (value.IsEmailSuppressedEventDataVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Resend.EmailSuppressedEventDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Resend.EmailSuppressedEventDataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Resend.EmailSuppressedEventDataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmailSuppressedEventDataVariant2!, typeInfo);
            }
        }
    }
}