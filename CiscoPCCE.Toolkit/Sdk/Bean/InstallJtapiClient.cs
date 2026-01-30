using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("installJtapiClient")]
    public class InstallJtapiClient : BaseApiBean
    {
        [XmlElement("callManagerPublisherAddress")]
        public string? CallManagerPublisherAddress { get; set; }

        [XmlElement("callManagerPublisherVersion")]
        public string? CallManagerPublisherVersion { get; set; }
    }
}