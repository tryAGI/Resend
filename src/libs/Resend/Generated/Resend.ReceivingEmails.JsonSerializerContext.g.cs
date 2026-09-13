
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachmentContentDisposition), TypeInfoPropertyName = "RetrievedAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition), TypeInfoPropertyName = "ListAttachmentsResponseDataItemContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetReceivedEmailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetReceivedEmailResponseAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition), TypeInfoPropertyName = "GetReceivedEmailResponseAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition), TypeInfoPropertyName = "ListReceivedEmailsResponseDataItemAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachmentContentDisposition?), TypeInfoPropertyName = "NullableRetrievedAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?), TypeInfoPropertyName = "NullableListAttachmentsResponseDataItemContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition?), TypeInfoPropertyName = "NullableGetReceivedEmailResponseAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition?), TypeInfoPropertyName = "NullableListReceivedEmailsResponseDataItemAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>))]
    internal sealed partial class ReceivingEmailsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceivingEmailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReceivingEmailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReceivingEmailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Resend.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?)

                    || typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition))
                {
                    return new global::Resend.JsonConverters.RetrievedAttachmentContentDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition?))
                {
                    return new global::Resend.JsonConverters.RetrievedAttachmentContentDispositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition))
                {
                    return new global::Resend.JsonConverters.ListAttachmentsResponseDataItemContentDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?))
                {
                    return new global::Resend.JsonConverters.ListAttachmentsResponseDataItemContentDispositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition))
                {
                    return new global::Resend.JsonConverters.GetReceivedEmailResponseAttachmentContentDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition?))
                {
                    return new global::Resend.JsonConverters.GetReceivedEmailResponseAttachmentContentDispositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition))
                {
                    return new global::Resend.JsonConverters.ListReceivedEmailsResponseDataItemAttachmentContentDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition?))
                {
                    return new global::Resend.JsonConverters.ListReceivedEmailsResponseDataItemAttachmentContentDispositionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ReceivingEmailsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}