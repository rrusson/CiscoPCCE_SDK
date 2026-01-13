using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("location")
    [XmlRoot("location")]
    public class Location : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("cucmHostAddress")]
        public string? CucmHostAddress { get; set; }

        [XmlArray("datacenters")]
        [XmlArrayItem("datacenter")]
        public List<ReferenceBean>? Datacenters { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlArray("gateways")]
        [XmlArrayItem("gateway")]
        public List<ReferenceBean>? Gateways { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("locationCode")]
        public string? LocationCode { get; set; }

        [XmlElement("locationName")]
        public string? LocationName { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}