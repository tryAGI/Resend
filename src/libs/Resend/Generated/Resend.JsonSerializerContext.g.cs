
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
            typeof(global::Resend.JsonConverters.DomainCapabilitiesSendingJsonConverter),

            typeof(global::Resend.JsonConverters.DomainCapabilitiesSendingNullableJsonConverter),

            typeof(global::Resend.JsonConverters.DomainCapabilitiesReceivingJsonConverter),

            typeof(global::Resend.JsonConverters.DomainCapabilitiesReceivingNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateDomainRequestRegionJsonConverter),

            typeof(global::Resend.JsonConverters.CreateDomainRequestRegionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateDomainRequestTlsJsonConverter),

            typeof(global::Resend.JsonConverters.CreateDomainRequestTlsNullableJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordRecordJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordRecordNullableJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordTypeJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordStatusJsonConverter),

            typeof(global::Resend.JsonConverters.DomainRecordStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateApiKeyRequestPermissionJsonConverter),

            typeof(global::Resend.JsonConverters.CreateApiKeyRequestPermissionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateContactOptionsTopicSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.CreateContactOptionsTopicSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.RetrievedAttachmentContentDispositionJsonConverter),

            typeof(global::Resend.JsonConverters.RetrievedAttachmentContentDispositionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.ListAttachmentsResponseDataItemContentDispositionJsonConverter),

            typeof(global::Resend.JsonConverters.ListAttachmentsResponseDataItemContentDispositionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.GetReceivedEmailResponseAttachmentContentDispositionJsonConverter),

            typeof(global::Resend.JsonConverters.GetReceivedEmailResponseAttachmentContentDispositionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.ListReceivedEmailsResponseDataItemAttachmentContentDispositionJsonConverter),

            typeof(global::Resend.JsonConverters.ListReceivedEmailsResponseDataItemAttachmentContentDispositionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateWebhookRequestStatusJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateWebhookRequestStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateVariableTypeJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateVariableTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateVariableInputTypeJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateVariableInputTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateStatusJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateListItemStatusJsonConverter),

            typeof(global::Resend.JsonConverters.TemplateListItemStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateTopicOptionsDefaultSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.CreateTopicOptionsDefaultSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateTopicOptionsVisibilityJsonConverter),

            typeof(global::Resend.JsonConverters.CreateTopicOptionsVisibilityNullableJsonConverter),

            typeof(global::Resend.JsonConverters.GetTopicResponseSuccessDefaultSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.GetTopicResponseSuccessDefaultSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.GetTopicResponseSuccessVisibilityJsonConverter),

            typeof(global::Resend.JsonConverters.GetTopicResponseSuccessVisibilityNullableJsonConverter),

            typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemDefaultSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemDefaultSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemVisibilityJsonConverter),

            typeof(global::Resend.JsonConverters.ListTopicsResponseSuccessDataItemVisibilityNullableJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateTopicOptionsVisibilityJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateTopicOptionsVisibilityNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateContactPropertyOptionsTypeJsonConverter),

            typeof(global::Resend.JsonConverters.CreateContactPropertyOptionsTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.GetContactTopicsResponseSuccessDataItemSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.GetContactTopicsResponseSuccessDataItemSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateContactTopicsOptionsTopicSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateContactTopicsOptionsTopicSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateContactTopicsResponseSuccessTopicSubscriptionJsonConverter),

            typeof(global::Resend.JsonConverters.UpdateContactTopicsResponseSuccessTopicSubscriptionNullableJsonConverter),

            typeof(global::Resend.JsonConverters.LogSummaryMethodJsonConverter),

            typeof(global::Resend.JsonConverters.LogSummaryMethodNullableJsonConverter),

            typeof(global::Resend.JsonConverters.LogMethodJsonConverter),

            typeof(global::Resend.JsonConverters.LogMethodNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStepTypeJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStepTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStepResponseTypeJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStepResponseTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationConnectionTypeJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationConnectionTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.CreateAutomationRequestStatusJsonConverter),

            typeof(global::Resend.JsonConverters.CreateAutomationRequestStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStatusJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationListItemStatusJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationListItemStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.PatchAutomationRequestStatusJsonConverter),

            typeof(global::Resend.JsonConverters.PatchAutomationRequestStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunStepTypeJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunStepTypeNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunStatusJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunListItemStatusJsonConverter),

            typeof(global::Resend.JsonConverters.AutomationRunListItemStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.GetAutomationsStatusJsonConverter),

            typeof(global::Resend.JsonConverters.GetAutomationsStatusNullableJsonConverter),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Resend.JsonConverters.AllOfJsonConverter<global::Resend.EmailTemplateInput, object>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Resend.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Resend.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Email))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListEmailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.Email>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBatchEmailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBatchEmailsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesSending), TypeInfoPropertyName = "DomainCapabilitiesSending2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesReceiving), TypeInfoPropertyName = "DomainCapabilitiesReceiving2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestRegion), TypeInfoPropertyName = "CreateDomainRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestTls), TypeInfoPropertyName = "CreateDomainRequestTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordRecord), TypeInfoPropertyName = "DomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordType), TypeInfoPropertyName = "DomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordStatus), TypeInfoPropertyName = "DomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Domain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.VerifyDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyRequestPermission), TypeInfoPropertyName = "CreateApiKeyRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAudienceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAudienceResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetAudienceResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveAudienceResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAudiencesResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAudiencesResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptions))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBroadcastOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateBroadcastOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendBroadcastOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhooksResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookRequestStatus), TypeInfoPropertyName = "UpdateWebhookRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteWebhookResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateSegmentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateSegmentResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetSegmentResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSegmentsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSegmentsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveSegmentResponseSuccess))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactPropertyOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactPropertyOptionsType), TypeInfoPropertyName = "CreateContactPropertyOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactPropertyResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactPropertyResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactPropertiesResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListContactPropertiesResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactPropertyOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactPropertyResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveContactPropertyResponseSuccess))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.LogSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.LogSummaryMethod), TypeInfoPropertyName = "LogSummaryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Log))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.LogMethod), TypeInfoPropertyName = "LogMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.LogSummary>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EventSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EventSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetAutomationsStatus), TypeInfoPropertyName = "GetAutomationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Email>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateBatchEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListDomainsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.TemplateListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.LogSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EventSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.SendEmailRequest>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}