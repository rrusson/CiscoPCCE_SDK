using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("ucceVersion")]
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