
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Attachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Inbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxesResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListInboxesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxesResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveInboxResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentTone), TypeInfoPropertyName = "InboxAgentTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxAgentEnabledAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentEnabledAction), TypeInfoPropertyName = "InboxAgentEnabledAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsTone), TypeInfoPropertyName = "UpdateInboxAgentOptionsTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsEnabledAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction), TypeInfoPropertyName = "UpdateInboxAgentOptionsEnabledAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxLabelsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxLabelOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxLabelResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxLabelOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxLabelResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveInboxLabelResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolder), TypeInfoPropertyName = "InboxThreadFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSearchResult), TypeInfoPropertyName = "InboxThreadSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSearchResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSearchResultVariant2Highlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummaryFolder), TypeInfoPropertyName = "InboxThreadSummaryFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxThreadsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SearchInboxThreadsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThreadSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptionsFolder), TypeInfoPropertyName = "UpdateInboxThreadOptionsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveInboxThreadResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmailAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmailDirection), TypeInfoPropertyName = "InboxThreadEmailDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThreadEmailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxThreadEmailsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThreadEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ReplyInboxThreadEmailOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ReplyInboxThreadEmailResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ForwardInboxThreadEmailOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ForwardInboxThreadEmailResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftAttachmentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftType), TypeInfoPropertyName = "InboxDraftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftListItemType), TypeInfoPropertyName = "InboxDraftListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxDraftsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxDraftListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxDraftOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxDraftOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendInboxDraftOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesListThreadsFolder), TypeInfoPropertyName = "InboxesListThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesSearchThreadsFolder), TypeInfoPropertyName = "InboxesSearchThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentTone?), TypeInfoPropertyName = "NullableInboxAgentTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentEnabledAction?), TypeInfoPropertyName = "NullableInboxAgentEnabledAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsTone?), TypeInfoPropertyName = "NullableUpdateInboxAgentOptionsTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction?), TypeInfoPropertyName = "NullableUpdateInboxAgentOptionsEnabledAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolder?), TypeInfoPropertyName = "NullableInboxThreadFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSearchResult?), TypeInfoPropertyName = "NullableInboxThreadSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummaryFolder?), TypeInfoPropertyName = "NullableInboxThreadSummaryFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptionsFolder?), TypeInfoPropertyName = "NullableUpdateInboxThreadOptionsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmailDirection?), TypeInfoPropertyName = "NullableInboxThreadEmailDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftType?), TypeInfoPropertyName = "NullableInboxDraftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftListItemType?), TypeInfoPropertyName = "NullableInboxDraftListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesListThreadsFolder?), TypeInfoPropertyName = "NullableInboxesListThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesSearchThreadsFolder?), TypeInfoPropertyName = "NullableInboxesSearchThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListInboxesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxAgentEnabledAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateInboxAgentOptionsEnabledAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxThreadLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxThreadSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxThreadEmailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxThreadEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxDraftAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxDraftListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxDraftAttachmentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxesListThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxesSearchThreadsFolder>))]
    internal sealed partial class InboxesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboxesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InboxesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InboxesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Resend.JsonConverters.InboxThreadSearchResultJsonConverter());
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
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
                    typeToConvert == typeof(global::Resend.InboxAgentTone)

                    || typeToConvert == typeof(global::Resend.InboxAgentTone?)

                    || typeToConvert == typeof(global::Resend.InboxAgentEnabledAction)

                    || typeToConvert == typeof(global::Resend.InboxAgentEnabledAction?)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone?)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction?)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolder)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolder?)

                    || typeToConvert == typeof(global::Resend.InboxThreadSummaryFolder)

                    || typeToConvert == typeof(global::Resend.InboxThreadSummaryFolder?)

                    || typeToConvert == typeof(global::Resend.UpdateInboxThreadOptionsFolder)

                    || typeToConvert == typeof(global::Resend.UpdateInboxThreadOptionsFolder?)

                    || typeToConvert == typeof(global::Resend.InboxThreadEmailDirection)

                    || typeToConvert == typeof(global::Resend.InboxThreadEmailDirection?)

                    || typeToConvert == typeof(global::Resend.InboxDraftType)

                    || typeToConvert == typeof(global::Resend.InboxDraftType?)

                    || typeToConvert == typeof(global::Resend.InboxDraftListItemType)

                    || typeToConvert == typeof(global::Resend.InboxDraftListItemType?)

                    || typeToConvert == typeof(global::Resend.InboxesListThreadsFolder)

                    || typeToConvert == typeof(global::Resend.InboxesListThreadsFolder?)

                    || typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder)

                    || typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Resend.InboxAgentTone))
                {
                    return new global::Resend.JsonConverters.InboxAgentToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentTone?))
                {
                    return new global::Resend.JsonConverters.InboxAgentToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentEnabledAction))
                {
                    return new global::Resend.JsonConverters.InboxAgentEnabledActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentEnabledAction?))
                {
                    return new global::Resend.JsonConverters.InboxAgentEnabledActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone?))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsEnabledActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsEnabledAction?))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsEnabledActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolder))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolder?))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadSummaryFolder))
                {
                    return new global::Resend.JsonConverters.InboxThreadSummaryFolderJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadSummaryFolder?))
                {
                    return new global::Resend.JsonConverters.InboxThreadSummaryFolderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxThreadOptionsFolder))
                {
                    return new global::Resend.JsonConverters.UpdateInboxThreadOptionsFolderJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxThreadOptionsFolder?))
                {
                    return new global::Resend.JsonConverters.UpdateInboxThreadOptionsFolderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadEmailDirection))
                {
                    return new global::Resend.JsonConverters.InboxThreadEmailDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadEmailDirection?))
                {
                    return new global::Resend.JsonConverters.InboxThreadEmailDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxDraftType))
                {
                    return new global::Resend.JsonConverters.InboxDraftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxDraftType?))
                {
                    return new global::Resend.JsonConverters.InboxDraftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxDraftListItemType))
                {
                    return new global::Resend.JsonConverters.InboxDraftListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxDraftListItemType?))
                {
                    return new global::Resend.JsonConverters.InboxDraftListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxesListThreadsFolder))
                {
                    return new global::Resend.JsonConverters.InboxesListThreadsFolderJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxesListThreadsFolder?))
                {
                    return new global::Resend.JsonConverters.InboxesListThreadsFolderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder))
                {
                    return new global::Resend.JsonConverters.InboxesSearchThreadsFolderJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder?))
                {
                    return new global::Resend.JsonConverters.InboxesSearchThreadsFolderNullableJsonConverter();
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
                    0 => new InboxesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}