
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
        public global::Resend.EmailLastEvent? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEmailsResponse? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.Email>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponse? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponseDataItem? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilities? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesSending? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesReceiving? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequest? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestRegion? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestTls? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponse? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponseStatus? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecord? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordRecord? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordType? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordStatus? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Domain? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainStatus? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecord? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaim? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimStatus? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRegion? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsResponse? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItem? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ApiKey? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListOAuthGrantsResponse? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OAuthGrant>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OAuthGrant? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OAuthGrantClient? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RevokeOAuthGrantResponse? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptions? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactOptions? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportCounts? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImport? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportStatus? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CancelBroadcastResponseSuccess? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachment? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetWebhookResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariable? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableType? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInput? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Template2? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateStatus? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItem? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptions? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummary? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummaryMethod? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Log? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogMethod? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListLogsResponse? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStep? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepType? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponse? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnection? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnectionType? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Automation? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStatus? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItem? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.StopAutomationResponse? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStep? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStepType? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRun? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStatus? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItem? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Event? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EventSummary? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventRequest? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEventsResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventRequest? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventResponse? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveEventResponse? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventRequest? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventResponse? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounce? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventClick? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventFailed? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventData? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventData? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactEventData? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventData? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSentEvent? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEvent? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEvent? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSuppressionOptions? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSuppressionResponseSuccess? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsOptions? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccess? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccessDataItem? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsOptions? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccess? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSuppressionResponseSuccess? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccess? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccessOrigin? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccess? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItem? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactsImportsStatus? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAutomationsStatus? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSuppressionsOrigin? Type326 { get; set; }

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
        public global::System.Collections.Generic.List<global::Resend.OAuthGrant>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ContactImport>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariable>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateListItem>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.LogSummary>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStep>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationConnection>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationListItem>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunStep>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EventSummary>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OutboundEmailEventDataHeader>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookEventAttachment>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookDomainRecord>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSuppressionsResponseSuccessDataItem>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.SendEmailRequest>? ListType46 { get; set; }
    }
}