using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("applicationPath")]
    public class ApplicationPath : BaseApiBean
    {
        [XmlElement("applicationInstance")]
        public required ReferenceBean ApplicationInstance { get; set; }

        [XmlArray("applicationPathMembers")]
        [XmlArrayItem("applicationPathMember")]
        public List<ApplicationPathMember>? ApplicationPathMembers { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("logicalControllerId")]
        public int? LogicalControllerId { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
        
    }
}