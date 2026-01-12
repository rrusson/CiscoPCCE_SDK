using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("reporting")]
    public class ReportingGlobalSetting : BaseApiBean
    {
        [XmlElement("reportingInterval")]
        public int? ReportingInterval { get; set; }
        
    }
}