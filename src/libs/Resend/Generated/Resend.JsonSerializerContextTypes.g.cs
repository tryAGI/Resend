
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
        public global::Resend.GetUsageResponseSuccess? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessEmails? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessEmailsDaily? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessEmailsMonthly? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessContacts? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessSegments? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessBroadcasts? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessAiCredits? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessAutomationRuns? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessDomains? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetUsageResponseSuccessRateLimit? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBatchEmailsResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateBatchEmailsResponseDataItem>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBatchEmailsResponseDataItem? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilities? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilitiesSending? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCapabilitiesReceiving? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequestRegion? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainRequestTls? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainResponseStatus? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.DomainRecord>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecord? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainOptions? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainOptionsTls? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordRecord? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainRecordStatus? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Domain? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainStatus? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecord? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaim? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimStatus? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRegion? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItem? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ApiKey? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListOAuthGrantsResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OAuthGrant>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrant? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrantClient? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RevokeOAuthGrantResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptions? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsSegment>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsSegment? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactOptions? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportCounts? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImport? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportStatus? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CancelBroadcastResponseSuccess? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateBroadcastResponseSuccess? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccess? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItem? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccess? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachment? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RotateWebhookSigningSecretResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventsResponseDataItem>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItem? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItemStatus? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponseStatus? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventAttemptsResponseDataItem>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponseDataItem? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ReplayWebhookEventResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariable? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInput? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Template2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateStatus? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItem? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentOptions? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentResponseSuccess? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptions? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummary? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummaryMethod? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Log? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogMethod? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListLogsResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStep? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnection? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnectionType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Automation? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStatus? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItem? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateAutomationResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.StopAutomationResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStep? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStepType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRun? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStatus? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItem? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Event? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EventSummary? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListEventsResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveEventResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounce? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventClick? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventFailed? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventData? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventData? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactEventData? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventData? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionEventData? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionEventDataOrigin? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSentEvent? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEvent? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEvent? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionAddedEvent? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionRemovedEvent? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionOptions? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionResponseSuccess? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsOptions? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccess? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccessDataItem? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsOptions? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccess? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSuppressionResponseSuccess? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccess? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccessOrigin? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccess? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItem? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsGranularity? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsMetric? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsDimension? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactsListImportsStatus? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsType? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsBounceType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationsListStatus? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionsListOrigin? Type386 { get; set; }

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