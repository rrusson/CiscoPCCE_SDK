using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ivr")]
    public class IVRServiceConfig : BaseApiBean
    {
        [XmlElement("callTimeout")]
        public int? CallTimeout { get; set; }

        [XmlElement("useBackupMediaServers")]
        public bool? UseBackupMediaServers { get; set; }

        [XmlElement("useMediaServerHostNames")]
        public bool? UseMediaServerHostNames { get; set; }

        [XmlElement("useSecurityForMediaFetches")]
        public bool? UseSecurityForMediaFetches { get; set; }
    }
}