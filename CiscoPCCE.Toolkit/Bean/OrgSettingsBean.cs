using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("OrgSettings")]
    public class OrgSettingsBean : BaseApiBean
    {
        public string? AccessToken { get; set; }

        public string? IdBrokerHost { get; set; }

        public string? IdHost { get; set; }

        public string? OrgID { get; set; }
    }
}