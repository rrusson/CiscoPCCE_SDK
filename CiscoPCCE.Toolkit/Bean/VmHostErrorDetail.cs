using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class VmHostErrorDetail : BaseApiBean
    {
        [XmlElement("hosts")]
        [XmlElement("hostInfo")]
        public List<VMHost>? HostNames { get; set; }
    }
}