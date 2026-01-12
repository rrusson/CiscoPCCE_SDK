using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("stats")
    [XmlRoot("stats")]
    public class Stats : BaseApiBean
    {
        [XmlElement("numberOfAgentsLoggedIn")]
        public int NumberOfAgentsLoggedIn { get; set; }
        
    }
}