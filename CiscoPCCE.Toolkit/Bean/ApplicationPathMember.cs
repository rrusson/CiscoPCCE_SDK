using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("applicationPathMember")]
    public class ApplicationPathMember : BaseApiBean
    {
        [XmlElement("applicationPathId")]
        public int? ApplicationPathId { get; set; }

        [XmlElement("mrDomainId")]
        public int? MrDomainId { get; set; }

        [XmlElement("peripheralId")]
        public short? PeripheralId { get; set; }
    }
}