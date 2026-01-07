using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("configuredStatus")]
    public class BusinessHourConfiguredStatus : BaseApiBean
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
        public class BusinessHourConfiguredStatusList : BaseApiListBean<BusinessHourConfiguredStatus>
        {
            public override List<BusinessHourConfiguredStatus>? GetItems() => Items;

            public override void SetItems(List<BusinessHourConfiguredStatus>? value) => Items = value;
        }
    }
}