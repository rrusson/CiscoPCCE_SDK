using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class ScriptReference : BaseApiBean
    {
        [XmlElement("deleted")]
        public bool? Deleted { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("##default")]
        public List<int?>? Versions { get; set; }
    }
}