using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class Permissions : BaseApiBean
    {
        [XmlElement("id")]
        public string? Id { get; set; }

        public List<User>? UserList { get; set; }
    }
}