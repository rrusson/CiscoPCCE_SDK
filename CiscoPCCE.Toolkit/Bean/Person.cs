using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("person")]
    public class Person : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("digitalChannel")]
        public bool? DigitalChannel { get; set; }

        [XmlElement("ecePerson")]
        public bool? EcePerson { get; set; }

        [XmlElement("emailAddress")]
        public string? EmailAddress { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("loginEnabled")]
        public bool? LoginEnabled { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("screenName")]
        public string? ScreenName { get; set; }

        [XmlElement("ssoEnabled")]
        public bool? SsoEnabled { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}