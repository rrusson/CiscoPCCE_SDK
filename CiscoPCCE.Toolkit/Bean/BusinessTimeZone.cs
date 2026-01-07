using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesstimezone")
    [XmlRoot("businesstimezone")]
    public class BusinessTimeZone : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("businesstimezone")]
        public string? BusinessTimeZoneName { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        // Path("businesstimezone")
        [XmlRoot("results")]
        public class BusinessTimeZoneList : BaseApiListBean<BusinessTimeZone>
        {
            public override List<BusinessTimeZone>? GetItems() => Items;

            public override void SetItems(List<BusinessTimeZone>? value) => Items = value;
        }
    }
}