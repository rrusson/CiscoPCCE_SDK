using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ucceVersion")]
    public class UcceVersion : BaseApiBean
    {
        [XmlElement("buildVersion")]
        public int BuildVersion { get; set; }

        [XmlElement("esVersion")]
        public int EsVersion { get; set; }

        [XmlElement("maintenanceVersion")]
        public int MaintenanceVersion { get; set; }

        [XmlElement("majorVersion")]
        public int MajorVersion { get; set; }

        [XmlElement("minorVersion")]
        public int MinorVersion { get; set; }

        [XmlElement("srVersion")]
        public int SrVersion { get; set; }
    }
}