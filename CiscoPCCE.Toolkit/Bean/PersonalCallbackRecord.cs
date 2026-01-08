using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("personalCallback")]
    public class PersonalCallbackRecord : BaseApiBean
    {
        [XmlElement("accountNumber")]
        public string? AccountNumber { get; set; }

        [XmlElement("agent")]
        public required ReferenceBean Agent { get; set; }

        [XmlElement("agentId")]
        public string? AgentId { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callResult")]
        public short? CallResult { get; set; }

        [XmlElement("callStatus")]
        public CallStatusEnum CallStatusEnum { get; set; }

        [XmlElement("callbackDateTime")]
        public DateTime? CallbackDateTime { get; set; }

        [XmlElement("campaign")]
        public required ReferenceBean Campaign { get; set; }

        [XmlElement("campaignDn")]
        public string? CampaignDn { get; set; }

        [XmlElement("campaignId")]
        public int? CampaignId { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("maxAttempts")]
        public int? MaxAttempts { get; set; }

        [XmlElement("peripheralId")]
        public int? PeripheralId { get; set; }

        [XmlElement("phone")]
        public string? Phone { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("personalcallback")
        [XmlRoot("results")]
        public class PersonalCallbackRecordList : BaseApiListBean<PersonalCallbackRecord>
        {
            public override List<PersonalCallbackRecord>? GetItems() => Items;

            public override void SetItems(List<PersonalCallbackRecord>? value) => Items = value;
        }
    }
}