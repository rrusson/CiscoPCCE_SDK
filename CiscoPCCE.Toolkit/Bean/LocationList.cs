using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("locations")]
    public class LocationList : BaseApiBean
    {
        public List<Location>? Location { get; set; }
    }
}