
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEmailRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, global::System.Collections.Generic.IList<string>>? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AllOf<global::Resend.EmailTemplateInput, object>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailTemplateInput? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.Attachment>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Attachment? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.Tag>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Tag? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEmailResponse? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEmailOptions? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Email? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailLastEvent? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEmailsResponse? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.Email>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponse? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponseDataItem? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilities? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesSending? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesReceiving? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequest? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestRegion? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestTls? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponse? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponseStatus? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecord? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordRecord? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordType? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordStatus? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Domain? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainStatus? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecord? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaim? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimStatus? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRegion? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsResponse? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItem? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ApiKey? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptions? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactOptions? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportCounts? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImport? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportStatus? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachment? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetWebhookResponse? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariable? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableType? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInput? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Template2? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateStatus? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItem? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptions? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummary? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummaryMethod? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Log? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogMethod? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListLogsResponse? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStep? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepType? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponse? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnection? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnectionType? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Automation? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStatus? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItem? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.StopAutomationResponse? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStep? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStepType? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRun? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStatus? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItem? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Event? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EventSummary? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventRequest? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventResponse? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEventsResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventRequest? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventResponse? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveEventResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventRequest? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounce? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventClick? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventFailed? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventData? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventData? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactEventData? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventData? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSentEvent? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEvent? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEvent? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactsImportsStatus? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAutomationsStatus? Type302 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.Attachment>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.Tag>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.Email>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateBatchEmailsResponseDataItem>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.DomainRecord>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListDomainsItem>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ApiKey>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ContactImport>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariable>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateListItem>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.LogSummary>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStep>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationConnection>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationListItem>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunStep>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EventSummary>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OutboundEmailEventDataHeader>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookEventAttachment>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookDomainRecord>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.SendEmailRequest>? ListType42 { get; set; }
    }
}