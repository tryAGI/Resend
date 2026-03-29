
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
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecord? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordRecord? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordType? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DomainRecordStatus? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Domain? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsResponse? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListDomainsItem? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ApiKey? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptions? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactOptions? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachment? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetWebhookResponse? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariable? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableType? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInput? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.Template2? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateStatus? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItem? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptions? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type180 { get; set; }

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
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariable>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateListItem>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.SendEmailRequest>? ListType30 { get; set; }
    }
}