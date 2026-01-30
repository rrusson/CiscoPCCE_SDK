using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("activeDirectoryDomain")]
    public class ActiveDirectoryDomain : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("systemDomain")]
        public bool? SystemDomain { get; set; }
    }
}