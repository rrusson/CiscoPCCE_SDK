using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("location")
    [XmlRoot("location")]
    public class Location : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public string? CucmHostAddress { get; set; }

        [XmlElement("datacenters")]
        [XmlElement("datacenter")]
        public List<ReferenceBean>? Datacenters { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        [XmlElement("gateways")]
        [XmlElement("gateway")]
        public List<ReferenceBean>? Gateways { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? LocationCode { get; set; }

        public string? LocationName { get; set; }

        public new string? RefURL { get; set; }

        // Path("location")
        [XmlRoot("results")]
        public class LocationList : BaseApiListBean<Location>
        {
            public override List<Location>? GetItems() => Items;

            public override void SetItems(List<Location>? value) => Items = value;
        }
    }
}