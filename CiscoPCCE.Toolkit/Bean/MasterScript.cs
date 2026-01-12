using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("masterScript")]
    public class MasterScript : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("currentVersion")]
        public int? CurrentVersion { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("script")]
        public required ScriptVersion Script { get; set; }

        [XmlElement("scriptType")]
        public int? ScriptType { get; set; }

        [XmlArray("##default")]
        [XmlArrayItem("scriptVersion")]
        public List<ReferenceBean>? ScriptVersions { get; set; }
        
    }
}