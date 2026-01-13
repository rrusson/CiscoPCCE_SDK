using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationAuthCode : BaseApiBean
    {
        [XmlElement("authorizationCode")]
        public string? AuthorizationCode { get; set; }
    }
}