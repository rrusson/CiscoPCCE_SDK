using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("user")]
    public class ECEUser : BaseApiBean
    {
        [XmlElement("department")]
        public required ECEDepartment Department { get; set; }

        [XmlElement("externalId")]
        public int? ExternalId { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("loginId")]
        public string? LoginId { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("screenName")]
        public string? ScreenName { get; set; }
    }
}