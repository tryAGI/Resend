
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableType), TypeInfoPropertyName = "TemplateVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "OneOfStringDoubleBooleanObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableInputType), TypeInfoPropertyName = "TemplateVariableInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Template2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.TemplateVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateStatus), TypeInfoPropertyName = "TemplateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateListItemStatus), TypeInfoPropertyName = "TemplateListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTemplateResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTemplatesResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.TemplateListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTemplateOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTemplateResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveTemplateResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.PublishTemplateResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DuplicateTemplateResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableType?), TypeInfoPropertyName = "NullableTemplateVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableInputType?), TypeInfoPropertyName = "NullableTemplateVariableInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateStatus?), TypeInfoPropertyName = "NullableTemplateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateListItemStatus?), TypeInfoPropertyName = "NullableTemplateListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateListItem>))]
    internal sealed partial class TemplatesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TemplatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TemplatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Resend.TemplateVariableType)

                    || typeToConvert == typeof(global::Resend.TemplateVariableType?)

                    || typeToConvert == typeof(global::Resend.TemplateVariableInputType)

                    || typeToConvert == typeof(global::Resend.TemplateVariableInputType?)

                    || typeToConvert == typeof(global::Resend.TemplateStatus)

                    || typeToConvert == typeof(global::Resend.TemplateStatus?)

                    || typeToConvert == typeof(global::Resend.TemplateListItemStatus)

                    || typeToConvert == typeof(global::Resend.TemplateListItemStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.TemplateVariableType))
                {
                    return new global::Resend.JsonConverters.TemplateVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateVariableType?))
                {
                    return new global::Resend.JsonConverters.TemplateVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateVariableInputType))
                {
                    return new global::Resend.JsonConverters.TemplateVariableInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateVariableInputType?))
                {
                    return new global::Resend.JsonConverters.TemplateVariableInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateStatus))
                {
                    return new global::Resend.JsonConverters.TemplateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateStatus?))
                {
                    return new global::Resend.JsonConverters.TemplateStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateListItemStatus))
                {
                    return new global::Resend.JsonConverters.TemplateListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TemplateListItemStatus?))
                {
                    return new global::Resend.JsonConverters.TemplateListItemStatusNullableJsonConverter();
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
                    0 => new TemplatesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}