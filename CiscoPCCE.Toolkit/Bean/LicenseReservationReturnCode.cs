using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationReturnCode : BaseApiBean
    {
        [XmlElement("returnReservationCode")]
        public string? ReturnReservationCode { get; set; }
    }
}