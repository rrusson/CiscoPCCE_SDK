using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("personalCallback")]
    public class PersonalCallbackRecord : BaseApiBean
    {
        public string? AccountNumber { get; set; }

        public required ReferenceBean Agent { get; set; }

        public string? AgentId { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public short? CallResult { get; set; }

        [XmlElement("callStatus")]
        public CallStatusEnum CallStatusEnum { get; set; }

        public DateTime? CallbackDateTime { get; set; }

        public required ReferenceBean Campaign { get; set; }

        public string? CampaignDn { get; set; }

        public int? CampaignId { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? FirstName { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? LastName { get; set; }

        public int? MaxAttempts { get; set; }

        public int? PeripheralId { get; set; }

        public string? Phone { get; set; }

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