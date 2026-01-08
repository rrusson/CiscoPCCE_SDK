using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vmHost")]
    public class VMHost : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("systemDefault")]
        public bool? SystemDefault { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}