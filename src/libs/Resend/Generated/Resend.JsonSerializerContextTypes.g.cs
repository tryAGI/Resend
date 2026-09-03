
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

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
        public global::Resend.GetEmailsMetricsResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetEmailsMetricsResponseDimension>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetEmailsMetricsResponseDimension? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetEmailsMetricsResponseGranularity? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailMetricsDataRow>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailMetricsDataRow? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBatchEmailsResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBatchEmailsResponseDataItem? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilities? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilitiesSending? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilitiesReceiving? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequestRegion? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequestTls? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainResponse? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainResponseStatus? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecord? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordRecord? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordStatus? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Domain? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainStatus? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecord? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaim? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRegion? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItem? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ApiKey? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListOAuthGrantsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OAuthGrant>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrant? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrantClient? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RevokeOAuthGrantResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptions? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsSegment>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsSegment? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactOptions? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportCounts? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImport? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CancelBroadcastResponseSuccess? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccess? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItem? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccess? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachment? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookResponse? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventsResponseDataItem>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItem? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItemStatus? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponseStatus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventAttemptsResponseDataItem>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponseDataItem? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ReplayWebhookEventResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariable? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInput? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Template2? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateStatus? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentOptions? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentResponseSuccess? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptions? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummary? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummaryMethod? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Log? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogMethod? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListLogsResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStep? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnection? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnectionType? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Automation? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStatus? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItem? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateAutomationResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.StopAutomationResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStep? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStepType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRun? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStatus? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItem? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Event? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EventSummary? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListEventsResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveEventResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounce? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventClick? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventFailed? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventData? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventData? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactEventData? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventData? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSentEvent? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEvent? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEvent? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionOptions? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionResponseSuccess? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsOptions? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccess? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccessDataItem? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsOptions? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccess? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSuppressionResponseSuccess? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccess? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccessOrigin? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccess? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsGranularity? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsMetric? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsDimension? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactsListImportsStatus? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsBounceType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationsListStatus? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionsListOrigin? Type369 { get; set; }

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
        public global::System.Collections.Generic.List<global::Resend.GetEmailsMetricsResponseDimension>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EmailMetricsDataRow>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateBatchEmailsResponseDataItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.DomainRecord>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListDomainsItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ApiKey>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OAuthGrant>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsSegment>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ContactImport>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhookEventsResponseDataItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhookEventAttemptsResponseDataItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariable>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateListItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.LogSummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStep>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationConnection>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationListItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunStep>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EventSummary>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OutboundEmailEventDataHeader>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookEventAttachment>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookDomainRecord>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSuppressionsResponseSuccessDataItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.SendEmailRequest>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EmailsMetricsMetric>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EmailsMetricsDimension>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType57 { get; set; }
    }
}