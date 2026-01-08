using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("timezone")]
    public class TimeZoneLocation : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("displayName")]
        public string? DisplayName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("timezone")
        [XmlRoot("results")]
        public class TimeZoneLocationList : BaseApiListBean<TimeZoneLocation>
        {
            public override List<TimeZoneLocation>? GetItems() => Items;

            public override void SetItems(List<TimeZoneLocation>? value) => Items = value;
        }
    }
}