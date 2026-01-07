using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationReturnCode : BaseApiBean
    {
        public string? ReturnReservationCode { get; set; }
    }
}