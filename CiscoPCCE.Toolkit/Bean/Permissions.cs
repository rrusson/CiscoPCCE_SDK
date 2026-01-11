using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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