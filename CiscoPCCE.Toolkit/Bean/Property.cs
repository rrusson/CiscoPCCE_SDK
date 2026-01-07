using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("property")]
    public class Property : BaseApiBean
    {
        public string? Name { get; set; }

        public string? Value { get; set; }
    }
}