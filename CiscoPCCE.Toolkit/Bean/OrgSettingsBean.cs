using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("OrgSettings")]
    public class OrgSettingsBean : BaseApiBean
    {
        [XmlElement("accessToken")]
        public string? AccessToken { get; set; }

        [XmlElement("idBrokerHost")]
        public string? IdBrokerHost { get; set; }

        [XmlElement("idHost")]
        public string? IdHost { get; set; }

        [XmlElement("orgID")]
        public string? OrgID { get; set; }
    }
}