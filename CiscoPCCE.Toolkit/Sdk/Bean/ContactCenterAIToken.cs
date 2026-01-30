using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("contactCenterAIToken")]
    public class ContactCenterAIToken : BaseApiBean
    {
        [XmlElement("accessToken")]
        public string? AccessToken { get; set; }

        [XmlElement("cmsUrl")]
        public string? CmsUrl { get; set; }

        [XmlElement("expiresIn")]
        public string? ExpiresIn { get; set; }

        [XmlElement("orgId")]
        public string? OrgId { get; set; }

        [XmlElement("u2cHost")]
        public string? U2cHost { get; set; }
    }
}