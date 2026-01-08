using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("department")]
    public class ECEDepartment : BaseApiBean
    {
        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("externalId")]
        public int? ExternalId { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}