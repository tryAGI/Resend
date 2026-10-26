
#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessEmails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessEmailsDaily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessEmailsMonthly))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessContacts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessSegments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessBroadcasts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessAiCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessAutomationRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessDomains))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetUsageResponseSuccessRateLimit))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponseStatus), TypeInfoPropertyName = "CreateDomainResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainOptionsTls), TypeInfoPropertyName = "UpdateDomainOptionsTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordRecord), TypeInfoPropertyName = "DomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordType), TypeInfoPropertyName = "DomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordStatus), TypeInfoPropertyName = "DomainRecordStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyRequestPermission), TypeInfoPropertyName = "CreateApiKeyRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListOAuthGrantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.OAuthGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OAuthGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OAuthGrantClient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RevokeOAuthGrantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateApiKeyResponse))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAudienceOptions))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateAudienceResponseSuccess))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetAudienceResponseSuccess))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveAudienceResponseSuccess))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAudiencesResponseSuccess))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAudiencesResponseSuccessDataItem))]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CancelBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DuplicateBroadcastResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastRecipientsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType), TypeInfoPropertyName = "ListBroadcastRecipientsResponseSuccessDataItemBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastClickedLinksResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhooksResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookRequestStatus), TypeInfoPropertyName = "UpdateWebhookRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RotateWebhookSigningSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DeleteWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListWebhookEventsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventsResponseDataItemStatus), TypeInfoPropertyName = "ListWebhookEventsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetWebhookEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetWebhookEventResponseStatus), TypeInfoPropertyName = "GetWebhookEventResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventAttemptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ListWebhookEventAttemptsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventAttemptsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ReplayWebhookEventResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateSegmentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateSegmentResponseSuccess))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventBounce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventBounceSubType), TypeInfoPropertyName = "WebhookEventBounceSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventBounceType), TypeInfoPropertyName = "WebhookEventBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventClick))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventSuppressed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventSuppressedReason), TypeInfoPropertyName = "WebhookEventSuppressedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventSuppressedType), TypeInfoPropertyName = "WebhookEventSuppressedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordRecord), TypeInfoPropertyName = "WebhookDomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordType), TypeInfoPropertyName = "WebhookDomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordStatus), TypeInfoPropertyName = "WebhookDomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OutboundEmailEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OutboundEmailEventDataHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailBouncedEventData), TypeInfoPropertyName = "EmailBouncedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailBouncedEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailClickedEventData), TypeInfoPropertyName = "EmailClickedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailClickedEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailFailedEventData), TypeInfoPropertyName = "EmailFailedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailFailedEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailSuppressedEventData), TypeInfoPropertyName = "EmailSuppressedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailSuppressedEventDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailReceivedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactTopicsEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.ContactTopicsEventDataTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactTopicsEventDataTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactTopicsEventDataTopicSubscription), TypeInfoPropertyName = "ContactTopicsEventDataTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainEventDataStatus), TypeInfoPropertyName = "DomainEventDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainEventDataRegion), TypeInfoPropertyName = "DomainEventDataRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionEventDataOrigin), TypeInfoPropertyName = "SuppressionEventDataOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicEventDataDefaultSubscription), TypeInfoPropertyName = "TopicEventDataDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailSentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailDeliveredEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailDeliveryDelayedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailBouncedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailComplainedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailOpenedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailClickedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailScheduledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailSuppressedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailReceivedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactTopicsUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionRemovedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicDeletedEvent))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxAgentAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentAction), TypeInfoPropertyName = "InboxAgentAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsTone), TypeInfoPropertyName = "UpdateInboxAgentOptionsTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsAction), TypeInfoPropertyName = "UpdateInboxAgentOptionsAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummaryFolder), TypeInfoPropertyName = "InboxThreadSummaryFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListInboxThreadsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SearchInboxThreadsResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxThreadSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptionsFolder), TypeInfoPropertyName = "UpdateInboxThreadOptionsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AddInboxThreadLabelsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SetInboxThreadLabelsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadLabelList))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RemoveInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendInboxDraftOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SendInboxDraftResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventSource), TypeInfoPropertyName = "InboxEventSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventEmailAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventEmail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventEmailDirection), TypeInfoPropertyName = "InboxEventEmailDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxEventEmailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventDraftType), TypeInfoPropertyName = "InboxEventDraftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDeletedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmailEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom), TypeInfoPropertyName = "InboxThreadFolderUpdatedEventDataFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo), TypeInfoPropertyName = "InboxThreadFolderUpdatedEventDataTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadAssignedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadUnassignedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadLabelsUpdatedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftSentEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEmailReceivedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEmailSentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadAssignedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadUnassignedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadLabelsUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftSentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsGranularity), TypeInfoPropertyName = "EmailsMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsMetric), TypeInfoPropertyName = "EmailsMetricsMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsDimension), TypeInfoPropertyName = "EmailsMetricsDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactsListImportsStatus), TypeInfoPropertyName = "ContactsListImportsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BroadcastsRecipientsType), TypeInfoPropertyName = "BroadcastsRecipientsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BroadcastsRecipientsBounceType), TypeInfoPropertyName = "BroadcastsRecipientsBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationsListStatus), TypeInfoPropertyName = "AutomationsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionsListOrigin), TypeInfoPropertyName = "SuppressionsListOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesListThreadsFolder), TypeInfoPropertyName = "InboxesListThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesSearchThreadsFolder), TypeInfoPropertyName = "InboxesSearchThreadsFolder2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesSending?), TypeInfoPropertyName = "NullableDomainCapabilitiesSending2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainCapabilitiesReceiving?), TypeInfoPropertyName = "NullableDomainCapabilitiesReceiving2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestRegion?), TypeInfoPropertyName = "NullableCreateDomainRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainRequestTls?), TypeInfoPropertyName = "NullableCreateDomainRequestTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainResponseStatus?), TypeInfoPropertyName = "NullableCreateDomainResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateDomainOptionsTls?), TypeInfoPropertyName = "NullableUpdateDomainOptionsTls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordRecord?), TypeInfoPropertyName = "NullableDomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordType?), TypeInfoPropertyName = "NullableDomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainRecordStatus?), TypeInfoPropertyName = "NullableDomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainStatus?), TypeInfoPropertyName = "NullableDomainStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateDomainClaimRequestRegion?), TypeInfoPropertyName = "NullableCreateDomainClaimRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRecordType?), TypeInfoPropertyName = "NullableDomainClaimRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimStatus?), TypeInfoPropertyName = "NullableDomainClaimStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimRegion?), TypeInfoPropertyName = "NullableDomainClaimRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainClaimBlockedReason?), TypeInfoPropertyName = "NullableDomainClaimBlockedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListDomainsItemStatus?), TypeInfoPropertyName = "NullableListDomainsItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateApiKeyRequestPermission?), TypeInfoPropertyName = "NullableCreateApiKeyRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactOptionsTopicSubscription?), TypeInfoPropertyName = "NullableCreateContactOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactImportOptionsOnConflict?), TypeInfoPropertyName = "NullableCreateContactImportOptionsOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactImportStatus?), TypeInfoPropertyName = "NullableContactImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactImportResponseSuccess?), TypeInfoPropertyName = "NullableGetContactImportResponseSuccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType?), TypeInfoPropertyName = "NullableListBroadcastRecipientsResponseSuccessDataItemBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.RetrievedAttachmentContentDisposition?), TypeInfoPropertyName = "NullableRetrievedAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?), TypeInfoPropertyName = "NullableListAttachmentsResponseDataItemContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition?), TypeInfoPropertyName = "NullableGetReceivedEmailResponseAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition?), TypeInfoPropertyName = "NullableListReceivedEmailsResponseDataItemAttachmentContentDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateWebhookRequestStatus?), TypeInfoPropertyName = "NullableUpdateWebhookRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListWebhookEventsResponseDataItemStatus?), TypeInfoPropertyName = "NullableListWebhookEventsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetWebhookEventResponseStatus?), TypeInfoPropertyName = "NullableGetWebhookEventResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableType?), TypeInfoPropertyName = "NullableTemplateVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateVariableInputType?), TypeInfoPropertyName = "NullableTemplateVariableInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateStatus?), TypeInfoPropertyName = "NullableTemplateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TemplateListItemStatus?), TypeInfoPropertyName = "NullableTemplateListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsDefaultSubscription?), TypeInfoPropertyName = "NullableCreateTopicOptionsDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateTopicOptionsVisibility?), TypeInfoPropertyName = "NullableCreateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessDefaultSubscription?), TypeInfoPropertyName = "NullableGetTopicResponseSuccessDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetTopicResponseSuccessVisibility?), TypeInfoPropertyName = "NullableGetTopicResponseSuccessVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription?), TypeInfoPropertyName = "NullableListTopicsResponseSuccessDataItemDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListTopicsResponseSuccessDataItemVisibility?), TypeInfoPropertyName = "NullableListTopicsResponseSuccessDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateTopicOptionsVisibility?), TypeInfoPropertyName = "NullableUpdateTopicOptionsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.CreateContactPropertyOptionsType?), TypeInfoPropertyName = "NullableCreateContactPropertyOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription?), TypeInfoPropertyName = "NullableGetContactTopicsResponseSuccessDataItemSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription?), TypeInfoPropertyName = "NullableUpdateContactTopicsOptionsTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription?), TypeInfoPropertyName = "NullableUpdateContactTopicsResponseSuccessTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.LogSummaryMethod?), TypeInfoPropertyName = "NullableLogSummaryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.LogMethod?), TypeInfoPropertyName = "NullableLogMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventBounceSubType?), TypeInfoPropertyName = "NullableWebhookEventBounceSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventBounceType?), TypeInfoPropertyName = "NullableWebhookEventBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventSuppressedReason?), TypeInfoPropertyName = "NullableWebhookEventSuppressedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookEventSuppressedType?), TypeInfoPropertyName = "NullableWebhookEventSuppressedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordRecord?), TypeInfoPropertyName = "NullableWebhookDomainRecordRecord2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordType?), TypeInfoPropertyName = "NullableWebhookDomainRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.WebhookDomainRecordStatus?), TypeInfoPropertyName = "NullableWebhookDomainRecordStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailBouncedEventData?), TypeInfoPropertyName = "NullableEmailBouncedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailClickedEventData?), TypeInfoPropertyName = "NullableEmailClickedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailFailedEventData?), TypeInfoPropertyName = "NullableEmailFailedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailSuppressedEventData?), TypeInfoPropertyName = "NullableEmailSuppressedEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactTopicsEventDataTopicSubscription?), TypeInfoPropertyName = "NullableContactTopicsEventDataTopicSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainEventDataStatus?), TypeInfoPropertyName = "NullableDomainEventDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.DomainEventDataRegion?), TypeInfoPropertyName = "NullableDomainEventDataRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionEventDataOrigin?), TypeInfoPropertyName = "NullableSuppressionEventDataOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.TopicEventDataDefaultSubscription?), TypeInfoPropertyName = "NullableTopicEventDataDefaultSubscription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.GetSuppressionResponseSuccessOrigin?), TypeInfoPropertyName = "NullableGetSuppressionResponseSuccessOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin?), TypeInfoPropertyName = "NullableListSuppressionsResponseSuccessDataItemOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentTone?), TypeInfoPropertyName = "NullableInboxAgentTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxAgentAction?), TypeInfoPropertyName = "NullableInboxAgentAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsTone?), TypeInfoPropertyName = "NullableUpdateInboxAgentOptionsTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxAgentOptionsAction?), TypeInfoPropertyName = "NullableUpdateInboxAgentOptionsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolder?), TypeInfoPropertyName = "NullableInboxThreadFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSearchResult?), TypeInfoPropertyName = "NullableInboxThreadSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadSummaryFolder?), TypeInfoPropertyName = "NullableInboxThreadSummaryFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.UpdateInboxThreadOptionsFolder?), TypeInfoPropertyName = "NullableUpdateInboxThreadOptionsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadEmailDirection?), TypeInfoPropertyName = "NullableInboxThreadEmailDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftType?), TypeInfoPropertyName = "NullableInboxDraftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxDraftListItemType?), TypeInfoPropertyName = "NullableInboxDraftListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventSource?), TypeInfoPropertyName = "NullableInboxEventSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventEmailDirection?), TypeInfoPropertyName = "NullableInboxEventEmailDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxEventDraftType?), TypeInfoPropertyName = "NullableInboxEventDraftType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom?), TypeInfoPropertyName = "NullableInboxThreadFolderUpdatedEventDataFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo?), TypeInfoPropertyName = "NullableInboxThreadFolderUpdatedEventDataTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsGranularity?), TypeInfoPropertyName = "NullableEmailsMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsMetric?), TypeInfoPropertyName = "NullableEmailsMetricsMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.EmailsMetricsDimension?), TypeInfoPropertyName = "NullableEmailsMetricsDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.ContactsListImportsStatus?), TypeInfoPropertyName = "NullableContactsListImportsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BroadcastsRecipientsType?), TypeInfoPropertyName = "NullableBroadcastsRecipientsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.BroadcastsRecipientsBounceType?), TypeInfoPropertyName = "NullableBroadcastsRecipientsBounceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.AutomationsListStatus?), TypeInfoPropertyName = "NullableAutomationsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.SuppressionsListOrigin?), TypeInfoPropertyName = "NullableSuppressionsListOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesListThreadsFolder?), TypeInfoPropertyName = "NullableInboxesListThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.InboxesSearchThreadsFolder?), TypeInfoPropertyName = "NullableInboxesSearchThreadsFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.Email>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetEmailsMetricsResponseDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailMetricsDataRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateBatchEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.DomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListDomainsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.OAuthGrant>))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateContactOptionsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ContactImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListWebhookEventsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListWebhookEventAttemptsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.OutboundEmailEventDataHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.WebhookEventAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ContactTopicsEventDataTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.WebhookDomainRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListSuppressionsResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.ListInboxesResponseSuccessDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxAgentAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.UpdateInboxAgentOptionsAction>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxEventEmailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.SendEmailRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailsMetricsMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.EmailsMetricsDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxesListThreadsFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Resend.InboxesSearchThreadsFolder>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                internal static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Resend.JsonConverters.GetContactImportResponseSuccessJsonConverter());
            options.Converters.Add(new global::Resend.JsonConverters.EmailBouncedEventDataJsonConverter());
            options.Converters.Add(new global::Resend.JsonConverters.EmailClickedEventDataJsonConverter());
            options.Converters.Add(new global::Resend.JsonConverters.EmailFailedEventDataJsonConverter());
            options.Converters.Add(new global::Resend.JsonConverters.EmailSuppressedEventDataJsonConverter());
            options.Converters.Add(new global::Resend.JsonConverters.InboxThreadSearchResultJsonConverter());
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
                    typeToConvert == typeof(global::Resend.EmailLastEvent)

                    || typeToConvert == typeof(global::Resend.EmailLastEvent?)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseDimension?)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity)

                    || typeToConvert == typeof(global::Resend.GetEmailsMetricsResponseGranularity?)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesSending)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesSending?)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving)

                    || typeToConvert == typeof(global::Resend.DomainCapabilitiesReceiving?)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestRegion)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestRegion?)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestTls)

                    || typeToConvert == typeof(global::Resend.CreateDomainRequestTls?)

                    || typeToConvert == typeof(global::Resend.CreateDomainResponseStatus)

                    || typeToConvert == typeof(global::Resend.CreateDomainResponseStatus?)

                    || typeToConvert == typeof(global::Resend.UpdateDomainOptionsTls)

                    || typeToConvert == typeof(global::Resend.UpdateDomainOptionsTls?)

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

                    || typeToConvert == typeof(global::Resend.ListDomainsItemStatus?)

                    || typeToConvert == typeof(global::Resend.CreateApiKeyRequestPermission)

                    || typeToConvert == typeof(global::Resend.CreateApiKeyRequestPermission?)

                    || typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription)

                    || typeToConvert == typeof(global::Resend.CreateContactOptionsTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict)

                    || typeToConvert == typeof(global::Resend.CreateContactImportOptionsOnConflict?)

                    || typeToConvert == typeof(global::Resend.ContactImportStatus)

                    || typeToConvert == typeof(global::Resend.ContactImportStatus?)

                    || typeToConvert == typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType)

                    || typeToConvert == typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType?)

                    || typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.RetrievedAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition)

                    || typeToConvert == typeof(global::Resend.ListAttachmentsResponseDataItemContentDisposition?)

                    || typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.GetReceivedEmailResponseAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition)

                    || typeToConvert == typeof(global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition?)

                    || typeToConvert == typeof(global::Resend.UpdateWebhookRequestStatus)

                    || typeToConvert == typeof(global::Resend.UpdateWebhookRequestStatus?)

                    || typeToConvert == typeof(global::Resend.ListWebhookEventsResponseDataItemStatus)

                    || typeToConvert == typeof(global::Resend.ListWebhookEventsResponseDataItemStatus?)

                    || typeToConvert == typeof(global::Resend.GetWebhookEventResponseStatus)

                    || typeToConvert == typeof(global::Resend.GetWebhookEventResponseStatus?)

                    || typeToConvert == typeof(global::Resend.TemplateVariableType)

                    || typeToConvert == typeof(global::Resend.TemplateVariableType?)

                    || typeToConvert == typeof(global::Resend.TemplateVariableInputType)

                    || typeToConvert == typeof(global::Resend.TemplateVariableInputType?)

                    || typeToConvert == typeof(global::Resend.TemplateStatus)

                    || typeToConvert == typeof(global::Resend.TemplateStatus?)

                    || typeToConvert == typeof(global::Resend.TemplateListItemStatus)

                    || typeToConvert == typeof(global::Resend.TemplateListItemStatus?)

                    || typeToConvert == typeof(global::Resend.CreateTopicOptionsDefaultSubscription)

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

                    || typeToConvert == typeof(global::Resend.UpdateTopicOptionsVisibility?)

                    || typeToConvert == typeof(global::Resend.CreateContactPropertyOptionsType)

                    || typeToConvert == typeof(global::Resend.CreateContactPropertyOptionsType?)

                    || typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription)

                    || typeToConvert == typeof(global::Resend.GetContactTopicsResponseSuccessDataItemSubscription?)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsOptionsTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription)

                    || typeToConvert == typeof(global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.LogSummaryMethod)

                    || typeToConvert == typeof(global::Resend.LogSummaryMethod?)

                    || typeToConvert == typeof(global::Resend.LogMethod)

                    || typeToConvert == typeof(global::Resend.LogMethod?)

                    || typeToConvert == typeof(global::Resend.AutomationStepType)

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

                    || typeToConvert == typeof(global::Resend.WebhookEventBounceSubType)

                    || typeToConvert == typeof(global::Resend.WebhookEventBounceSubType?)

                    || typeToConvert == typeof(global::Resend.WebhookEventBounceType)

                    || typeToConvert == typeof(global::Resend.WebhookEventBounceType?)

                    || typeToConvert == typeof(global::Resend.WebhookEventSuppressedReason)

                    || typeToConvert == typeof(global::Resend.WebhookEventSuppressedReason?)

                    || typeToConvert == typeof(global::Resend.WebhookEventSuppressedType)

                    || typeToConvert == typeof(global::Resend.WebhookEventSuppressedType?)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordRecord)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordRecord?)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordType)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordType?)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordStatus)

                    || typeToConvert == typeof(global::Resend.WebhookDomainRecordStatus?)

                    || typeToConvert == typeof(global::Resend.ContactTopicsEventDataTopicSubscription)

                    || typeToConvert == typeof(global::Resend.ContactTopicsEventDataTopicSubscription?)

                    || typeToConvert == typeof(global::Resend.DomainEventDataStatus)

                    || typeToConvert == typeof(global::Resend.DomainEventDataStatus?)

                    || typeToConvert == typeof(global::Resend.DomainEventDataRegion)

                    || typeToConvert == typeof(global::Resend.DomainEventDataRegion?)

                    || typeToConvert == typeof(global::Resend.SuppressionEventDataOrigin)

                    || typeToConvert == typeof(global::Resend.SuppressionEventDataOrigin?)

                    || typeToConvert == typeof(global::Resend.TopicEventDataDefaultSubscription)

                    || typeToConvert == typeof(global::Resend.TopicEventDataDefaultSubscription?)

                    || typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin)

                    || typeToConvert == typeof(global::Resend.GetSuppressionResponseSuccessOrigin?)

                    || typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin)

                    || typeToConvert == typeof(global::Resend.ListSuppressionsResponseSuccessDataItemOrigin?)

                    || typeToConvert == typeof(global::Resend.InboxAgentTone)

                    || typeToConvert == typeof(global::Resend.InboxAgentTone?)

                    || typeToConvert == typeof(global::Resend.InboxAgentAction)

                    || typeToConvert == typeof(global::Resend.InboxAgentAction?)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone?)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsAction)

                    || typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsAction?)

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

                    || typeToConvert == typeof(global::Resend.InboxEventSource)

                    || typeToConvert == typeof(global::Resend.InboxEventSource?)

                    || typeToConvert == typeof(global::Resend.InboxEventEmailDirection)

                    || typeToConvert == typeof(global::Resend.InboxEventEmailDirection?)

                    || typeToConvert == typeof(global::Resend.InboxEventDraftType)

                    || typeToConvert == typeof(global::Resend.InboxEventDraftType?)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom?)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo)

                    || typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsGranularity)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsGranularity?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsMetric)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsMetric?)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsDimension)

                    || typeToConvert == typeof(global::Resend.EmailsMetricsDimension?)

                    || typeToConvert == typeof(global::Resend.ContactsListImportsStatus)

                    || typeToConvert == typeof(global::Resend.ContactsListImportsStatus?)

                    || typeToConvert == typeof(global::Resend.BroadcastsRecipientsType)

                    || typeToConvert == typeof(global::Resend.BroadcastsRecipientsType?)

                    || typeToConvert == typeof(global::Resend.BroadcastsRecipientsBounceType)

                    || typeToConvert == typeof(global::Resend.BroadcastsRecipientsBounceType?)

                    || typeToConvert == typeof(global::Resend.AutomationsListStatus)

                    || typeToConvert == typeof(global::Resend.AutomationsListStatus?)

                    || typeToConvert == typeof(global::Resend.SuppressionsListOrigin)

                    || typeToConvert == typeof(global::Resend.SuppressionsListOrigin?)

                    || typeToConvert == typeof(global::Resend.InboxesListThreadsFolder)

                    || typeToConvert == typeof(global::Resend.InboxesListThreadsFolder?)

                    || typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder)

                    || typeToConvert == typeof(global::Resend.InboxesSearchThreadsFolder?);
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

                if (typeToConvert == typeof(global::Resend.UpdateDomainOptionsTls))
                {
                    return new global::Resend.JsonConverters.UpdateDomainOptionsTlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateDomainOptionsTls?))
                {
                    return new global::Resend.JsonConverters.UpdateDomainOptionsTlsNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Resend.CreateApiKeyRequestPermission))
                {
                    return new global::Resend.JsonConverters.CreateApiKeyRequestPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateApiKeyRequestPermission?))
                {
                    return new global::Resend.JsonConverters.CreateApiKeyRequestPermissionNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType))
                {
                    return new global::Resend.JsonConverters.ListBroadcastRecipientsResponseSuccessDataItemBounceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType?))
                {
                    return new global::Resend.JsonConverters.ListBroadcastRecipientsResponseSuccessDataItemBounceTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Resend.UpdateWebhookRequestStatus))
                {
                    return new global::Resend.JsonConverters.UpdateWebhookRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateWebhookRequestStatus?))
                {
                    return new global::Resend.JsonConverters.UpdateWebhookRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListWebhookEventsResponseDataItemStatus))
                {
                    return new global::Resend.JsonConverters.ListWebhookEventsResponseDataItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ListWebhookEventsResponseDataItemStatus?))
                {
                    return new global::Resend.JsonConverters.ListWebhookEventsResponseDataItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetWebhookEventResponseStatus))
                {
                    return new global::Resend.JsonConverters.GetWebhookEventResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.GetWebhookEventResponseStatus?))
                {
                    return new global::Resend.JsonConverters.GetWebhookEventResponseStatusNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Resend.CreateContactPropertyOptionsType))
                {
                    return new global::Resend.JsonConverters.CreateContactPropertyOptionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.CreateContactPropertyOptionsType?))
                {
                    return new global::Resend.JsonConverters.CreateContactPropertyOptionsTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Resend.LogSummaryMethod))
                {
                    return new global::Resend.JsonConverters.LogSummaryMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.LogSummaryMethod?))
                {
                    return new global::Resend.JsonConverters.LogSummaryMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.LogMethod))
                {
                    return new global::Resend.JsonConverters.LogMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.LogMethod?))
                {
                    return new global::Resend.JsonConverters.LogMethodNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Resend.WebhookEventBounceSubType))
                {
                    return new global::Resend.JsonConverters.WebhookEventBounceSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventBounceSubType?))
                {
                    return new global::Resend.JsonConverters.WebhookEventBounceSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventBounceType))
                {
                    return new global::Resend.JsonConverters.WebhookEventBounceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventBounceType?))
                {
                    return new global::Resend.JsonConverters.WebhookEventBounceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventSuppressedReason))
                {
                    return new global::Resend.JsonConverters.WebhookEventSuppressedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventSuppressedReason?))
                {
                    return new global::Resend.JsonConverters.WebhookEventSuppressedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventSuppressedType))
                {
                    return new global::Resend.JsonConverters.WebhookEventSuppressedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookEventSuppressedType?))
                {
                    return new global::Resend.JsonConverters.WebhookEventSuppressedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordRecord))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordRecordJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordRecord?))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordRecordNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordType))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordType?))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordStatus))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.WebhookDomainRecordStatus?))
                {
                    return new global::Resend.JsonConverters.WebhookDomainRecordStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactTopicsEventDataTopicSubscription))
                {
                    return new global::Resend.JsonConverters.ContactTopicsEventDataTopicSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactTopicsEventDataTopicSubscription?))
                {
                    return new global::Resend.JsonConverters.ContactTopicsEventDataTopicSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainEventDataStatus))
                {
                    return new global::Resend.JsonConverters.DomainEventDataStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainEventDataStatus?))
                {
                    return new global::Resend.JsonConverters.DomainEventDataStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainEventDataRegion))
                {
                    return new global::Resend.JsonConverters.DomainEventDataRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.DomainEventDataRegion?))
                {
                    return new global::Resend.JsonConverters.DomainEventDataRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionEventDataOrigin))
                {
                    return new global::Resend.JsonConverters.SuppressionEventDataOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionEventDataOrigin?))
                {
                    return new global::Resend.JsonConverters.SuppressionEventDataOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TopicEventDataDefaultSubscription))
                {
                    return new global::Resend.JsonConverters.TopicEventDataDefaultSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.TopicEventDataDefaultSubscription?))
                {
                    return new global::Resend.JsonConverters.TopicEventDataDefaultSubscriptionNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Resend.InboxAgentTone))
                {
                    return new global::Resend.JsonConverters.InboxAgentToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentTone?))
                {
                    return new global::Resend.JsonConverters.InboxAgentToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentAction))
                {
                    return new global::Resend.JsonConverters.InboxAgentActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxAgentAction?))
                {
                    return new global::Resend.JsonConverters.InboxAgentActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsTone?))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsAction))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.UpdateInboxAgentOptionsAction?))
                {
                    return new global::Resend.JsonConverters.UpdateInboxAgentOptionsActionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Resend.InboxEventSource))
                {
                    return new global::Resend.JsonConverters.InboxEventSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxEventSource?))
                {
                    return new global::Resend.JsonConverters.InboxEventSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxEventEmailDirection))
                {
                    return new global::Resend.JsonConverters.InboxEventEmailDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxEventEmailDirection?))
                {
                    return new global::Resend.JsonConverters.InboxEventEmailDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxEventDraftType))
                {
                    return new global::Resend.JsonConverters.InboxEventDraftTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxEventDraftType?))
                {
                    return new global::Resend.JsonConverters.InboxEventDraftTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderUpdatedEventDataFromJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataFrom?))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderUpdatedEventDataFromNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderUpdatedEventDataToJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.InboxThreadFolderUpdatedEventDataTo?))
                {
                    return new global::Resend.JsonConverters.InboxThreadFolderUpdatedEventDataToNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Resend.ContactsListImportsStatus))
                {
                    return new global::Resend.JsonConverters.ContactsListImportsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.ContactsListImportsStatus?))
                {
                    return new global::Resend.JsonConverters.ContactsListImportsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.BroadcastsRecipientsType))
                {
                    return new global::Resend.JsonConverters.BroadcastsRecipientsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.BroadcastsRecipientsType?))
                {
                    return new global::Resend.JsonConverters.BroadcastsRecipientsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.BroadcastsRecipientsBounceType))
                {
                    return new global::Resend.JsonConverters.BroadcastsRecipientsBounceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.BroadcastsRecipientsBounceType?))
                {
                    return new global::Resend.JsonConverters.BroadcastsRecipientsBounceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationsListStatus))
                {
                    return new global::Resend.JsonConverters.AutomationsListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.AutomationsListStatus?))
                {
                    return new global::Resend.JsonConverters.AutomationsListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionsListOrigin))
                {
                    return new global::Resend.JsonConverters.SuppressionsListOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Resend.SuppressionsListOrigin?))
                {
                    return new global::Resend.JsonConverters.SuppressionsListOriginNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}