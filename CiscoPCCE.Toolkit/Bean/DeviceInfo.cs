using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DeviceInfo : BaseApiBean
    {
        [XmlArray("locations")]
        [XmlArrayItem("location")]
        public List<string?>? Locations { get; set; }

        [XmlElement("typeName")]
        public string? TypeName { get; set; }
    }
}