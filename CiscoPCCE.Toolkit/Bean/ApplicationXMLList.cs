using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("applications")]
    public class ApplicationXMLList : BaseApiBean
    {
        [XmlElement("application")]
        public List<Application>? Items { get; set; }
    }
}