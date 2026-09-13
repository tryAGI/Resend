
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesSending), TypeInfoPropertyName = "DomainCapabilitiesSending2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesReceiving), TypeInfoPropertyName = "DomainCapabilitiesReceiving2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestRegion), TypeInfoPropertyName = "CreateDomainRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestTls), TypeInfoPropertyName = "CreateDomainRequestTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponseStatus), TypeInfoPropertyName = "CreateDomainResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordRecord), TypeInfoPropertyName = "DomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordType), TypeInfoPropertyName = "DomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordStatus), TypeInfoPropertyName = "DomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Domain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainStatus), TypeInfoPropertyName = "DomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainClaimRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainClaimRequestRegion), TypeInfoPropertyName = "CreateDomainClaimRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRecordType), TypeInfoPropertyName = "DomainClaimRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimStatus), TypeInfoPropertyName = "DomainClaimStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRegion), TypeInfoPropertyName = "DomainClaimRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimBlockedReason), TypeInfoPropertyName = "DomainClaimBlockedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.VerifyDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsItemStatus), TypeInfoPropertyName = "ListDomainsItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesSending?), TypeInfoPropertyName = "NullableDomainCapabilitiesSending2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesReceiving?), TypeInfoPropertyName = "NullableDomainCapabilitiesReceiving2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestRegion?), TypeInfoPropertyName = "NullableCreateDomainRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestTls?), TypeInfoPropertyName = "NullableCreateDomainRequestTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponseStatus?), TypeInfoPropertyName = "NullableCreateDomainResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordRecord?), TypeInfoPropertyName = "NullableDomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordType?), TypeInfoPropertyName = "NullableDomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordStatus?), TypeInfoPropertyName = "NullableDomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainStatus?), TypeInfoPropertyName = "NullableDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainClaimRequestRegion?), TypeInfoPropertyName = "NullableCreateDomainClaimRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRecordType?), TypeInfoPropertyName = "NullableDomainClaimRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimStatus?), TypeInfoPropertyName = "NullableDomainClaimStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRegion?), TypeInfoPropertyName = "NullableDomainClaimRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimBlockedReason?), TypeInfoPropertyName = "NullableDomainClaimBlockedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsItemStatus?), TypeInfoPropertyName = "NullableListDomainsItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListDomainsItem>))]
    internal sealed partial class DomainsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DomainsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DomainsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DomainsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Resend.DomainCapabilitiesSending)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesSending?)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving?)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestRegion)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestRegion?)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestTls)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestTls?)

                    || typeToConvert == typeof(global::Resend.CreateDomainResponseStatus)

                    || typeToConvert == typeof(global::Resend.CreateDomainResponseStatus?)

                    || typeToConvert == typeof(global::Resend.DomainRecordRecord)

                    || typeToConvert == typeof(global::Resend.DomainRecordRecord?)

                    || typeToConvert == typeof(global::Resend.DomainRecordType)

                    || typeToConvert == typeof(global::Resend.DomainRecordType?)

                    || typeToConvert == typeof(global::Resend.DomainRecordStatus)

                    || typeToConvert == typeof(global::Resend.DomainRecordStatus?)

                    || typeToConvert == typeof(global::Resend.DomainStatus)

                    || typeToConvert == typeof(global::Resend.DomainStatus?)

                    || typeToConvert == typeof(global::Resend.CreateDomainClaimRequestRegion)

                    || typeToConvert == typeof(global::Resend.CreateDomainClaimRequestRegion?)

                    || typeToConvert == typeof(global::Resend.DomainClaimRecordType)

                    || typeToConvert == typeof(global::Resend.DomainClaimRecordType?)

                    || typeToConvert == typeof(global::Resend.DomainClaimStatus)

                    || typeToConvert == typeof(global::Resend.DomainClaimStatus?)

                    || typeToConvert == typeof(global::Resend.DomainClaimRegion)

                    || typeToConvert == typeof(global::Resend.DomainClaimRegion?)

                    || typeToConvert == typeof(global::Resend.DomainClaimBlockedReason)

                    || typeToConvert == typeof(global::Resend.DomainClaimBlockedReason?)

                    || typeToConvert == typeof(global::Resend.ListDomainsItemStatus)

                    || typeToConvert == typeof(global::Resend.ListDomainsItemStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.DomainCapabilitiesSending))
                {
                    return new global::Resend.JsonConverters.DomainCapabilitiesSendingJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainCapabilitiesSending?))
                {
                    return new global::Resend.JsonConverters.DomainCapabilitiesSendingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving))
                {
                    return new global::Resend.JsonConverters.DomainCapabilitiesReceivingJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving?))
                {
                    return new global::Resend.JsonConverters.DomainCapabilitiesReceivingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainRequestRegion))
                {
                    return new global::Resend.JsonConverters.CreateDomainRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainRequestRegion?))
                {
                    return new global::Resend.JsonConverters.CreateDomainRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainRequestTls))
                {
                    return new global::Resend.JsonConverters.CreateDomainRequestTlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainRequestTls?))
                {
                    return new global::Resend.JsonConverters.CreateDomainRequestTlsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainResponseStatus))
                {
                    return new global::Resend.JsonConverters.CreateDomainResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainResponseStatus?))
                {
                    return new global::Resend.JsonConverters.CreateDomainResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordRecord))
                {
                    return new global::Resend.JsonConverters.DomainRecordRecordJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordRecord?))
                {
                    return new global::Resend.JsonConverters.DomainRecordRecordNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordType))
                {
                    return new global::Resend.JsonConverters.DomainRecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordType?))
                {
                    return new global::Resend.JsonConverters.DomainRecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordStatus))
                {
                    return new global::Resend.JsonConverters.DomainRecordStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainRecordStatus?))
                {
                    return new global::Resend.JsonConverters.DomainRecordStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainStatus))
                {
                    return new global::Resend.JsonConverters.DomainStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainStatus?))
                {
                    return new global::Resend.JsonConverters.DomainStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainClaimRequestRegion))
                {
                    return new global::Resend.JsonConverters.CreateDomainClaimRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateDomainClaimRequestRegion?))
                {
                    return new global::Resend.JsonConverters.CreateDomainClaimRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimRecordType))
                {
                    return new global::Resend.JsonConverters.DomainClaimRecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimRecordType?))
                {
                    return new global::Resend.JsonConverters.DomainClaimRecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimStatus))
                {
                    return new global::Resend.JsonConverters.DomainClaimStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimStatus?))
                {
                    return new global::Resend.JsonConverters.DomainClaimStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimRegion))
                {
                    return new global::Resend.JsonConverters.DomainClaimRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimRegion?))
                {
                    return new global::Resend.JsonConverters.DomainClaimRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimBlockedReason))
                {
                    return new global::Resend.JsonConverters.DomainClaimBlockedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainClaimBlockedReason?))
                {
                    return new global::Resend.JsonConverters.DomainClaimBlockedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListDomainsItemStatus))
                {
                    return new global::Resend.JsonConverters.ListDomainsItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListDomainsItemStatus?))
                {
                    return new global::Resend.JsonConverters.ListDomainsItemStatusNullableJsonConverter();
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
                    0 => new DomainsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}