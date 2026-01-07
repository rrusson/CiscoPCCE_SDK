using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("cvpDnis")]
    public class CvpDnis : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DnisList { get; set; }

        public string? Hostname { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }
    }
}