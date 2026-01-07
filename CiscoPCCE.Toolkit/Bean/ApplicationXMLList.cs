using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("applications")]
    public class ApplicationXMLList : BaseApiBean
    {
        [XmlElement("application")]
        public List<Application>? Items { get; set; }
    }
}