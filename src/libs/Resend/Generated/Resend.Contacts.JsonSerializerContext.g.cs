
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptionsSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptionsTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptionsTopicSubscription), TypeInfoPropertyName = "CreateContactOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveContactResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactImportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactImportOptionsOnConflict), TypeInfoPropertyName = "CreateContactImportOptionsOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactImportResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactImportCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactImportStatus), TypeInfoPropertyName = "ContactImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactImportResponseSuccess), TypeInfoPropertyName = "GetContactImportResponseSuccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactImportsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ContactImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AddContactToSegmentResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactSegmentsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactSegmentsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveContactFromSegmentResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactTopicsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactTopicsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription), TypeInfoPropertyName = "GetContactTopicsResponseSuccessDataItemSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsOptionsTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription), TypeInfoPropertyName = "UpdateContactTopicsOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsResponseSuccessTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription), TypeInfoPropertyName = "UpdateContactTopicsResponseSuccessTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactsListImportsStatus), TypeInfoPropertyName = "ContactsListImportsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptionsTopicSubscription?), TypeInfoPropertyName = "NullableCreateContactOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactImportOptionsOnConflict?), TypeInfoPropertyName = "NullableCreateContactImportOptionsOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactImportStatus?), TypeInfoPropertyName = "NullableContactImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactImportResponseSuccess?), TypeInfoPropertyName = "NullableGetContactImportResponseSuccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription?), TypeInfoPropertyName = "NullableGetContactTopicsResponseSuccessDataItemSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription?), TypeInfoPropertyName = "NullableUpdateContactTopicsOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription?), TypeInfoPropertyName = "NullableUpdateContactTopicsResponseSuccessTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactsListImportsStatus?), TypeInfoPropertyName = "NullableContactsListImportsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateContactOptionsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ContactImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>))]
    internal sealed partial class ContactsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ContactsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ContactsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Resend.JsonConverters.GetContactImportResponseSuccessJsonConverter());
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
                    typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription)

                    || typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict)

                    || typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict?)

                    || typeToConvert == typeof(global::Resend.ContactImportStatus)

                    || typeToConvert == typeof(global::Resend.ContactImportStatus?)

                    || typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription)

                    || typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription?)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.ContactsListImportsStatus)

                    || typeToConvert == typeof(global::Resend.ContactsListImportsStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription))
                {
                    return new global::Resend.JsonConverters.CreateContactOptionsTopicSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription?))
                {
                    return new global::Resend.JsonConverters.CreateContactOptionsTopicSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict))
                {
                    return new global::Resend.JsonConverters.CreateContactImportOptionsOnConflictJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict?))
                {
                    return new global::Resend.JsonConverters.CreateContactImportOptionsOnConflictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactImportStatus))
                {
                    return new global::Resend.JsonConverters.ContactImportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactImportStatus?))
                {
                    return new global::Resend.JsonConverters.ContactImportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription))
                {
                    return new global::Resend.JsonConverters.GetContactTopicsResponseSuccessDataItemSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription?))
                {
                    return new global::Resend.JsonConverters.GetContactTopicsResponseSuccessDataItemSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription))
                {
                    return new global::Resend.JsonConverters.UpdateContactTopicsOptionsTopicSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription?))
                {
                    return new global::Resend.JsonConverters.UpdateContactTopicsOptionsTopicSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription))
                {
                    return new global::Resend.JsonConverters.UpdateContactTopicsResponseSuccessTopicSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription?))
                {
                    return new global::Resend.JsonConverters.UpdateContactTopicsResponseSuccessTopicSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactsListImportsStatus))
                {
                    return new global::Resend.JsonConverters.ContactsListImportsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactsListImportsStatus?))
                {
                    return new global::Resend.JsonConverters.ContactsListImportsStatusNullableJsonConverter();
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
                    0 => new ContactsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}