
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStepType), TypeInfoPropertyName = "AutomationStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStepResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStepResponseType), TypeInfoPropertyName = "AutomationStepResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationConnectionType), TypeInfoPropertyName = "AutomationConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAutomationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAutomationRequestStatus), TypeInfoPropertyName = "CreateAutomationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Automation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStatus), TypeInfoPropertyName = "AutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationListItemStatus), TypeInfoPropertyName = "AutomationListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAutomationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.PatchAutomationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.PatchAutomationRequestStatus), TypeInfoPropertyName = "PatchAutomationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.PatchAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DuplicateAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.StopAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunStepType), TypeInfoPropertyName = "AutomationRunStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunStatus), TypeInfoPropertyName = "AutomationRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunListItemStatus), TypeInfoPropertyName = "AutomationRunListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAutomationRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationsListStatus), TypeInfoPropertyName = "AutomationsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStepType?), TypeInfoPropertyName = "NullableAutomationStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStepResponseType?), TypeInfoPropertyName = "NullableAutomationStepResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationConnectionType?), TypeInfoPropertyName = "NullableAutomationConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAutomationRequestStatus?), TypeInfoPropertyName = "NullableCreateAutomationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationStatus?), TypeInfoPropertyName = "NullableAutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationListItemStatus?), TypeInfoPropertyName = "NullableAutomationListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.PatchAutomationRequestStatus?), TypeInfoPropertyName = "NullablePatchAutomationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunStepType?), TypeInfoPropertyName = "NullableAutomationRunStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunStatus?), TypeInfoPropertyName = "NullableAutomationRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationRunListItemStatus?), TypeInfoPropertyName = "NullableAutomationRunListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationsListStatus?), TypeInfoPropertyName = "NullableAutomationsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>))]
    internal sealed partial class AutomationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AutomationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AutomationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Resend.AutomationStepType)

                    || typeToConvert == typeof(global::Resend.AutomationStepType?)

                    || typeToConvert == typeof(global::Resend.AutomationStepResponseType)

                    || typeToConvert == typeof(global::Resend.AutomationStepResponseType?)

                    || typeToConvert == typeof(global::Resend.AutomationConnectionType)

                    || typeToConvert == typeof(global::Resend.AutomationConnectionType?)

                    || typeToConvert == typeof(global::Resend.CreateAutomationRequestStatus)

                    || typeToConvert == typeof(global::Resend.CreateAutomationRequestStatus?)

                    || typeToConvert == typeof(global::Resend.AutomationStatus)

                    || typeToConvert == typeof(global::Resend.AutomationStatus?)

                    || typeToConvert == typeof(global::Resend.AutomationListItemStatus)

                    || typeToConvert == typeof(global::Resend.AutomationListItemStatus?)

                    || typeToConvert == typeof(global::Resend.PatchAutomationRequestStatus)

                    || typeToConvert == typeof(global::Resend.PatchAutomationRequestStatus?)

                    || typeToConvert == typeof(global::Resend.AutomationRunStepType)

                    || typeToConvert == typeof(global::Resend.AutomationRunStepType?)

                    || typeToConvert == typeof(global::Resend.AutomationRunStatus)

                    || typeToConvert == typeof(global::Resend.AutomationRunStatus?)

                    || typeToConvert == typeof(global::Resend.AutomationRunListItemStatus)

                    || typeToConvert == typeof(global::Resend.AutomationRunListItemStatus?)

                    || typeToConvert == typeof(global::Resend.AutomationsListStatus)

                    || typeToConvert == typeof(global::Resend.AutomationsListStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.AutomationStepType))
                {
                    return new global::Resend.JsonConverters.AutomationStepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationStepType?))
                {
                    return new global::Resend.JsonConverters.AutomationStepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationStepResponseType))
                {
                    return new global::Resend.JsonConverters.AutomationStepResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationStepResponseType?))
                {
                    return new global::Resend.JsonConverters.AutomationStepResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationConnectionType))
                {
                    return new global::Resend.JsonConverters.AutomationConnectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationConnectionType?))
                {
                    return new global::Resend.JsonConverters.AutomationConnectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateAutomationRequestStatus))
                {
                    return new global::Resend.JsonConverters.CreateAutomationRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateAutomationRequestStatus?))
                {
                    return new global::Resend.JsonConverters.CreateAutomationRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationStatus))
                {
                    return new global::Resend.JsonConverters.AutomationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationListItemStatus))
                {
                    return new global::Resend.JsonConverters.AutomationListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationListItemStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.PatchAutomationRequestStatus))
                {
                    return new global::Resend.JsonConverters.PatchAutomationRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.PatchAutomationRequestStatus?))
                {
                    return new global::Resend.JsonConverters.PatchAutomationRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunStepType))
                {
                    return new global::Resend.JsonConverters.AutomationRunStepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunStepType?))
                {
                    return new global::Resend.JsonConverters.AutomationRunStepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunStatus))
                {
                    return new global::Resend.JsonConverters.AutomationRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunListItemStatus))
                {
                    return new global::Resend.JsonConverters.AutomationRunListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationRunListItemStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationRunListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationsListStatus))
                {
                    return new global::Resend.JsonConverters.AutomationsListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationsListStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationsListStatusNullableJsonConverter();
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
                    0 => new AutomationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}