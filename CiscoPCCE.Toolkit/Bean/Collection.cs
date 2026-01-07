using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class Collection : BaseApiBean
    {
        public List<CollectionValue>? CollectionValues { get; set; }

        public string? Description { get; set; }

        public string? GroupPermission { get; set; }

        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Origin { get; set; }

        public string? Type { get; set; }

        public int? Version { get; set; }
    }
}