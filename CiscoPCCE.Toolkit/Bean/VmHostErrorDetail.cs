using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class VmHostErrorDetail : BaseApiBean
    {
        [XmlArray("hosts")]
        [XmlArrayItem("hostInfo")]
        public List<VMHost>? HostNames { get; set; }
    }
}