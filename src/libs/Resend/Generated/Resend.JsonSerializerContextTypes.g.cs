
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
        public global::Resend.ShareEmailOptions? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ShareEmailResponse? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Email? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailLastEvent? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEmailsResponse? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.Email>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponse? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBatchEmailsResponseDataItem? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilities? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesSending? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCapabilitiesReceiving? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequest? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestRegion? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainRequestTls? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponse? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainResponseStatus? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecord? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordRecord? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordType? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordStatus? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Domain? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainStatus? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecord? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaim? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimStatus? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimRegion? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsResponse? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItem? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ApiKey? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListOAuthGrantsResponse? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OAuthGrant>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OAuthGrant? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OAuthGrantClient? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RevokeOAuthGrantResponse? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateApiKeyRequest? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateApiKeyResponse? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptions? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactOptions? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportCounts? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImport? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImportStatus? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CancelBroadcastResponseSuccess? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachment? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetWebhookResponse? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariable? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableType? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInput? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Template2? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateStatus? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItem? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptions? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummary? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogSummaryMethod? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Log? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.LogMethod? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListLogsResponse? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStep? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepType? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponse? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnection? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationConnectionType? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Automation? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationStatus? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItem? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DuplicateAutomationResponse? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.StopAutomationResponse? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStep? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStepType? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRun? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunStatus? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItem? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Event? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EventSummary? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventRequest? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateEventResponse? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListEventsResponse? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventRequest? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateEventResponse? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveEventResponse? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventRequest? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendEventResponse? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounce? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventClick? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventFailed? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventData? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventData? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactEventData? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventData? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSentEvent? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEvent? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEvent? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSuppressionOptions? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSuppressionResponseSuccess? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsOptions? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccess? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccessDataItem? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsOptions? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccess? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSuppressionResponseSuccess? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccess? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccessOrigin? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccess? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItem? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactsListImportsStatus? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AutomationsListStatus? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SuppressionsListOrigin? Type331 { get; set; }

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