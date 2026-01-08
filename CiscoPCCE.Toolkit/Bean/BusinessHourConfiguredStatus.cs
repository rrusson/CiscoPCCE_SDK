using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("configuredStatus")]
    public class BusinessHourConfiguredStatus : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("status")]
        public int? Status { get; set; }

        [XmlElement("statusReason")]
        public required ReferenceBean StatusReason { get; set; }

        // Path("businesshour")
        [XmlRoot("results")]
        public class BusinessHourConfiguredStatusList : BaseApiListBean<BusinessHourConfiguredStatus>
        {
            public override List<BusinessHourConfiguredStatus>? GetItems() => Items;

            public override void SetItems(List<BusinessHourConfiguredStatus>? value) => Items = value;
        }
    }
}