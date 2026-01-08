using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationRequest : BaseApiBean
    {
        [XmlElement("reservationCode")]
        public string? ReservationCode { get; set; }
    }
}