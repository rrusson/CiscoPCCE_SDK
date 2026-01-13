using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("reporting")]
    public class ReportingGlobalSetting : BaseApiBean
    {
        [XmlElement("reportingInterval")]
        public int? ReportingInterval { get; set; }
    }
}