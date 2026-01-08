using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class AssociatedGroup : BaseApiBean
    {
        [XmlElement("groupName")]
        public string? GroupName { get; set; }

        [XmlElement("id")]
        public string? Id { get; set; }
    }
}