
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsDefaultSubscription), TypeInfoPropertyName = "CreateTopicOptionsDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsVisibility), TypeInfoPropertyName = "CreateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription), TypeInfoPropertyName = "GetTopicResponseSuccessDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessVisibility), TypeInfoPropertyName = "GetTopicResponseSuccessVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription), TypeInfoPropertyName = "ListTopicsResponseSuccessDataItemDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility), TypeInfoPropertyName = "ListTopicsResponseSuccessDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTopicOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTopicOptionsVisibility), TypeInfoPropertyName = "UpdateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTopicResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveTopicResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsDefaultSubscription?), TypeInfoPropertyName = "NullableCreateTopicOptionsDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsVisibility?), TypeInfoPropertyName = "NullableCreateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription?), TypeInfoPropertyName = "NullableGetTopicResponseSuccessDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessVisibility?), TypeInfoPropertyName = "NullableGetTopicResponseSuccessVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?), TypeInfoPropertyName = "NullableListTopicsResponseSuccessDataItemDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility?), TypeInfoPropertyName = "NullableListTopicsResponseSuccessDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTopicOptionsVisibility?), TypeInfoPropertyName = "NullableUpdateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>))]
    internal sealed partial class TopicsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TopicsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TopicsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TopicsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Resend.CreateTopicOptionsDefaultSubscription)

                    || typeToConvert == typeof(global::Resend.CreateTopicOptionsDefaultSubscription?)

                    || typeToConvert == typeof(global::Resend.CreateTopicOptionsVisibility)

                    || typeToConvert == typeof(global::Resend.CreateTopicOptionsVisibility?)

                    || typeToConvert == typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription)

                    || typeToConvert == typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription?)

                    || typeToConvert == typeof(global::Resend.GetTopicResponseSuccessVisibility)

                    || typeToConvert == typeof(global::Resend.GetTopicResponseSuccessVisibility?)

                    || typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription)

                    || typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?)

                    || typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility)

                    || typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility?)

                    || typeToConvert == typeof(global::Resend.UpdateTopicOptionsVisibility)

                    || typeToConvert == typeof(global::Resend.UpdateTopicOptionsVisibility?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.CreateTopicOptionsDefaultSubscription))
                {
                    return new global::Resend.JsonConverters.CreateTopicOptionsDefaultSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateTopicOptionsDefaultSubscription?))
                {
                    return new global::Resend.JsonConverters.CreateTopicOptionsDefaultSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateTopicOptionsVisibility))
                {
                    return new global::Resend.JsonConverters.CreateTopicOptionsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateTopicOptionsVisibility?))
                {
                    return new global::Resend.JsonConverters.CreateTopicOptionsVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription))
                {
                    return new global::Resend.JsonConverters.GetTopicResponseSuccessDefaultSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription?))
                {
                    return new global::Resend.JsonConverters.GetTopicResponseSuccessDefaultSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetTopicResponseSuccessVisibility))
                {
                    return new global::Resend.JsonConverters.GetTopicResponseSuccessVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetTopicResponseSuccessVisibility?))
                {
                    return new global::Resend.JsonConverters.GetTopicResponseSuccessVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription))
                {
                    return new global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemDefaultSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?))
                {
                    return new global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemDefaultSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility))
                {
                    return new global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility?))
                {
                    return new global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateTopicOptionsVisibility))
                {
                    return new global::Resend.JsonConverters.UpdateTopicOptionsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateTopicOptionsVisibility?))
                {
                    return new global::Resend.JsonConverters.UpdateTopicOptionsVisibilityNullableJsonConverter();
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
                    0 => new TopicsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}