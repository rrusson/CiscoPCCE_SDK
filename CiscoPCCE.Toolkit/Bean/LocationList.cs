using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("locations")]
    public class LocationList : BaseApiBean
    {
        public List<Location>? Location { get; set; }
    }
}