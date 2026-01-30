using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("results")]
    public class ConfigTasksStatusResults : BaseApiBean
    {
        [XmlElement("state")]
        public StateEnum State { get; set; }
    }
}