using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("realTimeStatus")]
    public class BusinessHourRealTimeStatus : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public int? Status { get; set; }

        public required ReferenceBean StatusReason { get; set; }

        // Path("businesshour")
        [XmlRoot("results")]
        public class BusinessHourRealTimeStatusList : BaseApiListBean<BusinessHourRealTimeStatus>
        {
            public override List<BusinessHourRealTimeStatus>? GetItems() => Items;

            public override void SetItems(List<BusinessHourRealTimeStatus>? value) => Items = value;
        }
    }
}