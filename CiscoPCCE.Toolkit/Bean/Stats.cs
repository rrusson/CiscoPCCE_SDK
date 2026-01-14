using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("stats")]
    public class Stats : BaseApiBean
    {
        [XmlElement("numberOfAgentsLoggedIn")]
        public int NumberOfAgentsLoggedIn { get; set; }
    }
}