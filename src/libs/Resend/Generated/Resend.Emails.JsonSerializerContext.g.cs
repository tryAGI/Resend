
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AllOf<global::Resend.EmailTemplateInput, object>), TypeInfoPropertyName = "AllOfEmailTemplateInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailTemplateInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Attachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Tag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendEmailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateEmailOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ShareEmailOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ShareEmailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Email))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailLastEvent), TypeInfoPropertyName = "EmailLastEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListEmailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.Email>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetEmailsMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.GetEmailsMetricsResponseDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetEmailsMetricsResponseDimension), TypeInfoPropertyName = "GetEmailsMetricsResponseDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetEmailsMetricsResponseGranularity), TypeInfoPropertyName = "GetEmailsMetricsResponseGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EmailMetricsDataRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailMetricsDataRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBatchEmailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBatchEmailsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachmentContentDisposition), TypeInfoPropertyName = "RetrievedAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition), TypeInfoPropertyName = "ListAttachmentsResponseDataItemContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsGranularity), TypeInfoPropertyName = "EmailsMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsMetric), TypeInfoPropertyName = "EmailsMetricsMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsDimension), TypeInfoPropertyName = "EmailsMetricsDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AllOf<global::Resend.EmailTemplateInput, object>?), TypeInfoPropertyName = "NullableAllOfEmailTemplateInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailLastEvent?), TypeInfoPropertyName = "NullableEmailLastEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetEmailsMetricsResponseDimension?), TypeInfoPropertyName = "NullableGetEmailsMetricsResponseDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetEmailsMetricsResponseGranularity?), TypeInfoPropertyName = "NullableGetEmailsMetricsResponseGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachmentContentDisposition?), TypeInfoPropertyName = "NullableRetrievedAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?), TypeInfoPropertyName = "NullableListAttachmentsResponseDataItemContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsGranularity?), TypeInfoPropertyName = "NullableEmailsMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsMetric?), TypeInfoPropertyName = "NullableEmailsMetricsMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsDimension?), TypeInfoPropertyName = "NullableEmailsMetricsDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Email>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetEmailsMetricsResponseDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailMetricsDataRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateBatchEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.SendEmailRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailsMetricsMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailsMetricsDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    internal sealed partial class EmailsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Resend.JsonConverters.AllOfJsonConverter<global::Resend.EmailTemplateInput, object>());
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
                    typeToConvert == typeof(global::Resend.EmailLastEvent)

                    || typeToConvert == typeof(global::Resend.EmailLastEvent?)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension?)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity?)

                    || typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsGranularity)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsGranularity?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsMetric)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsMetric?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsDimension)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsDimension?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.EmailLastEvent))
                {
                    return new global::Resend.JsonConverters.EmailLastEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailLastEvent?))
                {
                    return new global::Resend.JsonConverters.EmailLastEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension))
                {
                    return new global::Resend.JsonConverters.GetEmailsMetricsResponseDimensionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension?))
                {
                    return new global::Resend.JsonConverters.GetEmailsMetricsResponseDimensionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity))
                {
                    return new global::Resend.JsonConverters.GetEmailsMetricsResponseGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity?))
                {
                    return new global::Resend.JsonConverters.GetEmailsMetricsResponseGranularityNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Resend.EmailsMetricsGranularity))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailsMetricsGranularity?))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailsMetricsMetric))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailsMetricsMetric?))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailsMetricsDimension))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsDimensionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.EmailsMetricsDimension?))
                {
                    return new global::Resend.JsonConverters.EmailsMetricsDimensionNullableJsonConverter();
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
                    0 => new EmailsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}