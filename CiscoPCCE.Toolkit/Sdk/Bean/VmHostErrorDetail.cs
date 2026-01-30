using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class VmHostErrorDetail : BaseApiBean
    {
        [XmlArray("hosts")]
        [XmlArrayItem("hostInfo")]
        public List<VMHost>? HostNames { get; set; }
    }
}