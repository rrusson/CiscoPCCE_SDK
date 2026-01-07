using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("datacenter")]
    public class DataCenter12k : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }
    }
}