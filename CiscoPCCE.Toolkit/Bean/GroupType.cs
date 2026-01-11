using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("GroupType")]
    public class GroupType : BaseApiBean
    {
        [XmlElement("machines")]
        public required Machines Machines { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}