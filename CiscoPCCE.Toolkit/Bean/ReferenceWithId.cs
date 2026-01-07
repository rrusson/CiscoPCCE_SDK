using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class ReferenceWithId : BaseApiBean
    {
        public bool? Deleted { get; set; }

        public int? Id { get; set; }

        public string? Name { get; set; }
    }
}