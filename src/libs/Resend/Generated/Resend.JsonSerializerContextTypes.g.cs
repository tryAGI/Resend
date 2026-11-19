
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Resend.EnableForgeRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.VerifyDomainOptions? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.VerifyDomainOptionsScopeItem>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.VerifyDomainOptionsScopeItem? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateDomainClaimRequestRegion? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecord? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRecordType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaim? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimStatus? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimRegion? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainClaimBlockedReason? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.VerifyDomainResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListDomainsItem>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItem? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListDomainsItemStatus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateDomainResponseSuccess? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteDomainResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyRequestPermission? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateApiKeyResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListApiKeysResponse? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ApiKey>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ApiKey? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListOAuthGrantsResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OAuthGrant>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrant? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OAuthGrantClient? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RevokeOAuthGrantResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteApiKeyResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateApiKeyResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceOptions? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAudienceResponseSuccess? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetAudienceResponseSuccess? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveAudienceResponseSuccess? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccess? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAudiencesResponseSuccessDataItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAudiencesResponseSuccessDataItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptions? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsSegment>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsSegment? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.CreateContactOptionsTopic>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopic? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactOptionsTopicSubscription? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactResponseSuccess? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactResponseSuccess? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactOptions? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactResponseSuccess? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactResponseSuccess? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccess? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactsResponseSuccessDataItem>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactsResponseSuccessDataItem? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptions? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportOptionsOnConflict? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactImportResponseSuccess? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportCounts? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImport? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactImportStatus? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactImportResponseSuccess? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactImportsResponseSuccess? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactImport>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastOptions? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateBroadcastResponseSuccess? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccess? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastsResponseSuccessDataItem>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastsResponseSuccessDataItem? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetBroadcastResponseSuccess? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastOptions? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateBroadcastResponseSuccess? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveBroadcastResponseSuccess? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastOptions? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendBroadcastResponseSuccess? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CancelBroadcastResponseSuccess? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateBroadcastResponseSuccess? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccess? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItem? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemBounceType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccess? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachment? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RetrievedAttachmentContentDisposition? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListAttachmentsResponseDataItem>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItem? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAttachmentsResponseDataItemContentDisposition? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetReceivedEmailResponseAttachment>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachment? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetReceivedEmailResponseAttachmentContentDisposition? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItem>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItem? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachment? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListReceivedEmailsResponseDataItemAttachmentContentDisposition? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateWebhookResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhooksResponseDataItem>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhooksResponseDataItem? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookRequestStatus? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateWebhookResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RotateWebhookSigningSecretResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteWebhookResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventsResponseDataItem>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItem? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventsResponseDataItemStatus? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetWebhookEventResponseStatus? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListWebhookEventAttemptsResponseDataItem>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListWebhookEventAttemptsResponseDataItem? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ReplayWebhookEventResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariable? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInput? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateVariableInputType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Template? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariable>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateStatus? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItem? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TemplateListItemStatus? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateVariableInput>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTemplateResponseSuccess? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTemplatesResponseSuccess? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.TemplateListItem>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateOptions? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTemplateResponseSuccess? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTemplateResponseSuccess? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PublishTemplateResponseSuccess? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateTemplateResponseSuccess? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentOptions? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSegmentResponseSuccess? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSegmentResponseSuccess? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentOptions? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateSegmentResponseSuccess? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccess? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSegmentsResponseSuccessDataItem>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSegmentsResponseSuccessDataItem? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSegmentResponseSuccess? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptions? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsDefaultSubscription? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicOptionsVisibility? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateTopicResponseSuccess? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccess? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessDefaultSubscription? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetTopicResponseSuccessVisibility? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccess? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListTopicsResponseSuccessDataItem>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItem? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemDefaultSubscription? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListTopicsResponseSuccessDataItemVisibility? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptions? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicOptionsVisibility? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateTopicResponseSuccess? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveTopicResponseSuccess? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptions? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyOptionsType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateContactPropertyResponseSuccess? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactPropertyResponseSuccess? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccess? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactPropertiesResponseSuccessDataItem>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactPropertiesResponseSuccessDataItem? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyOptions? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactPropertyResponseSuccess? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactPropertyResponseSuccess? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AddContactToSegmentResponseSuccess? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccess? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListContactSegmentsResponseSuccessDataItem>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListContactSegmentsResponseSuccessDataItem? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveContactFromSegmentResponseSuccess? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccess? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.GetContactTopicsResponseSuccessDataItem>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItem? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetContactTopicsResponseSuccessDataItemSubscription? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptions? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsOptionsTopic>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopic? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsOptionsTopicSubscription? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccess? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateContactTopicsResponseSuccessTopic>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopic? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateContactTopicsResponseSuccessTopicSubscription? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummary? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogSummaryMethod? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Log? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.LogMethod? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListLogsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.LogSummary>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStep? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStepResponseType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnection? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationConnectionType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationRequestStatus? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStep>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationConnection>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateAutomationResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Automation? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationStatus? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationStepResponse>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItem? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationListItemStatus? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationsResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationListItem>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationRequestStatus? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.PatchAutomationResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DeleteAutomationResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DuplicateAutomationResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.StopAutomationResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CancelAutomationRunResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStep? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStepType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRun? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunStatus? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunStep>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItem? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationRunListItemStatus? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListAutomationRunsResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.AutomationRunListItem>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Event? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EventSummary? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateEventResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListEventsResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EventSummary>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateEventResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveEventResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventRequest? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendEventResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounce? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceSubType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventBounceType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventClick? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventFailed? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressed? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedReason? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventSuppressedType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookEventAttachment? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecord? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordRecord? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.WebhookDomainRecordStatus? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventData? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.OutboundEmailEventDataHeader>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OutboundEmailEventDataHeader? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventData? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventData? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventData? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventData? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEventData? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookEventAttachment>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactEventData? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactTopicsEventData? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ContactTopicsEventDataTopic>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactTopicsEventDataTopic? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactTopicsEventDataTopicSubscription? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventData? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataStatus? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainEventDataRegion? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.WebhookDomainRecord>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionEventData? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionEventDataOrigin? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TopicEventData? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TopicEventDataDefaultSubscription? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSentEvent? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveredEvent? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailDeliveryDelayedEvent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailBouncedEvent? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailComplainedEvent? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailOpenedEvent? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailClickedEvent? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailFailedEvent? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailScheduledEvent? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailSuppressedEvent? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailReceivedEvent? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactCreatedEvent? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactUpdatedEvent? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactDeletedEvent? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactTopicsUpdatedEvent? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainCreatedEvent? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainUpdatedEvent? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.DomainDeletedEvent? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionAddedEvent? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionRemovedEvent? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TopicCreatedEvent? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TopicUpdatedEvent? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.TopicDeletedEvent? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionOptions? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateSuppressionResponseSuccess? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsOptions? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccess? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchAddSuppressionsResponseSuccessDataItem? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsOptions? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccess? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveSuppressionResponseSuccess? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccess? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.GetSuppressionResponseSuccessOrigin? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccess? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListSuppressionsResponseSuccessDataItem>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItem? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListSuppressionsResponseSuccessDataItemOrigin? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.Inbox? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxOptions? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxResponseSuccess? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxesResponseSuccess? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.ListInboxesResponseSuccessDataItem>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxesResponseSuccessDataItem? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxOptions? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxResponseSuccess? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveInboxResponseSuccess? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxAgent? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxAgentTone? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxAgentAction>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxAgentAction? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxAgentOptions? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxAgentOptionsTone? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.UpdateInboxAgentOptionsAction>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxAgentOptionsAction? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxAgentResponseSuccess? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxLabel? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxLabelsResponseSuccess? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxLabel>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxLabelOptions? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxLabelResponseSuccess? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxLabelOptions? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxLabelResponseSuccess? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveInboxLabelResponseSuccess? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadLabel? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThread? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxThreadLabel>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadFolder? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadSearchResult? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadSearchResultVariant2? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadSummary? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadSummaryFolder? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxThreadsResponseSuccess? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxThread>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SearchInboxThreadsResponseSuccess? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxThreadSearchResult>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxThreadOptions? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxThreadOptionsFolder? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AddInboxThreadLabelsOptions? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SetInboxThreadLabelsOptions? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadLabelList? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveInboxThreadResponseSuccess? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadEmailAttachment? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadEmail? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadEmailDirection? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxThreadEmailAttachment>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxThreadEmailsResponseSuccess? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxThreadEmail>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ReplyInboxThreadEmailOptions? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ReplyInboxThreadEmailResponseSuccess? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ForwardInboxThreadEmailOptions? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ForwardInboxThreadEmailResponseSuccess? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftAttachmentInput? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftAttachment? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraft? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachment>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftListItem? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftListItemType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ListInboxDraftsResponseSuccess? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxDraftListItem>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxDraftOptions? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxDraftAttachmentInput>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.CreateInboxDraftResponseSuccess? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxDraftOptions? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.UpdateInboxDraftResponseSuccess? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.RemoveInboxDraftResponseSuccess? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendInboxDraftOptions? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SendInboxDraftResponseSuccess? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventSource? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventEmailAttachment? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventEmail? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventEmailDirection? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxEventEmailAttachment>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventDraft? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventDraftType? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEventData? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDeletedEventData? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadEmailEventData? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadFolderUpdatedEventData? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadFolderUpdatedEventDataFrom? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadFolderUpdatedEventDataTo? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadAssignedEventData? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadUnassignedEventData? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadLabelsUpdatedEventData? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftEventData? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftSentEventData? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxCreatedEvent? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxUpdatedEvent? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDeletedEvent? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadCreatedEvent? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEmailReceivedEvent? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxEmailSentEvent? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadFolderUpdatedEvent? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadAssignedEvent? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadUnassignedEvent? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadLabelsUpdatedEvent? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftCreatedEvent? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftUpdatedEvent? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftSentEvent? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxDraftDeletedEvent? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.SendEmailRequest>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsGranularity? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsMetric>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsMetric? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.EmailsMetricsDimension>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.EmailsMetricsDimension? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.ContactsListImportsStatus? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.BroadcastsRecipientsBounceType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.AutomationsListStatus? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.SuppressionsListOrigin? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxesListThreadsFolder>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxesListThreadsFolder? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Resend.InboxesSearchThreadsFolder>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxesSearchThreadsFolder? Type508 { get; set; }

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
        public global::System.Collections.Generic.List<global::Resend.VerifyDomainOptionsScopeItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListDomainsItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ApiKey>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OAuthGrant>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAudiencesResponseSuccessDataItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsSegment>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.CreateContactOptionsTopic>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactsResponseSuccessDataItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ContactImport>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastsResponseSuccessDataItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastRecipientsResponseSuccessDataItemClickedLink>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListBroadcastClickedLinksResponseSuccessDataItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListAttachmentsResponseDataItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetReceivedEmailResponseAttachment>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListReceivedEmailsResponseDataItemAttachment>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhooksResponseDataItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhookEventsResponseDataItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListWebhookEventAttemptsResponseDataItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Resend.OneOf<string, double?, bool?, object, global::System.Collections.Generic.List<object>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariable>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateVariableInput>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.TemplateListItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSegmentsResponseSuccessDataItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListTopicsResponseSuccessDataItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactPropertiesResponseSuccessDataItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListContactSegmentsResponseSuccessDataItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.GetContactTopicsResponseSuccessDataItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsOptionsTopic>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateContactTopicsResponseSuccessTopic>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.LogSummary>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStep>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationConnection>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationStepResponse>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationListItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunStep>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.AutomationRunListItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EventSummary>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.OutboundEmailEventDataHeader>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookEventAttachment>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ContactTopicsEventDataTopic>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.WebhookDomainRecord>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchAddSuppressionsResponseSuccessDataItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.BatchRemoveSuppressionsResponseSuccessDataItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListSuppressionsResponseSuccessDataItem>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.ListInboxesResponseSuccessDataItem>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxAgentAction>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.UpdateInboxAgentOptionsAction>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxLabel>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxThreadLabel>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxThread>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxThreadSearchResult>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxThreadEmailAttachment>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxThreadEmail>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxDraftAttachment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxDraftListItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxDraftAttachmentInput>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxEventEmailAttachment>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.SendEmailRequest>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EmailsMetricsMetric>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.EmailsMetricsDimension>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxesListThreadsFolder>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Resend.InboxesSearchThreadsFolder>? ListType74 { get; set; }
    }
}