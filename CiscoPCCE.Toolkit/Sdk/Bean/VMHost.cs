using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("vmHost")]
    public class VMHost : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("systemDefault")]
        public bool? SystemDefault { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}