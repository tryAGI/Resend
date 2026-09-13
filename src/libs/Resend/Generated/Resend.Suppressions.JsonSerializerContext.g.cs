
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateSuppressionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateSuppressionResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchAddSuppressionsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchAddSuppressionsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchAddSuppressionsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchRemoveSuppressionsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchRemoveSuppressionsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveSuppressionResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetSuppressionResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetSuppressionResponseSuccessOrigin), TypeInfoPropertyName = "GetSuppressionResponseSuccessOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSuppressionsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSuppressionsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin), TypeInfoPropertyName = "ListSuppressionsResponseSuccessDataItemOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionsListOrigin), TypeInfoPropertyName = "SuppressionsListOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetSuppressionResponseSuccessOrigin?), TypeInfoPropertyName = "NullableGetSuppressionResponseSuccessOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin?), TypeInfoPropertyName = "NullableListSuppressionsResponseSuccessDataItemOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionsListOrigin?), TypeInfoPropertyName = "NullableSuppressionsListOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListSuppressionsResponseSuccessDataItem>))]
    internal sealed partial class SuppressionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SuppressionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SuppressionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SuppressionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin)

                    || typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin?)

                    || typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin)

                    || typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin?)

                    || typeToConvert == typeof(global::Resend.SuppressionsListOrigin)

                    || typeToConvert == typeof(global::Resend.SuppressionsListOrigin?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin))
                {
                    return new global::Resend.JsonConverters.GetSuppressionResponseSuccessOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin?))
                {
                    return new global::Resend.JsonConverters.GetSuppressionResponseSuccessOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin))
                {
                    return new global::Resend.JsonConverters.ListSuppressionsResponseSuccessDataItemOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin?))
                {
                    return new global::Resend.JsonConverters.ListSuppressionsResponseSuccessDataItemOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionsListOrigin))
                {
                    return new global::Resend.JsonConverters.SuppressionsListOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionsListOrigin?))
                {
                    return new global::Resend.JsonConverters.SuppressionsListOriginNullableJsonConverter();
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
                    0 => new SuppressionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}