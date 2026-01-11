using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationRequest : BaseApiBean
    {
        [XmlElement("reservationCode")]
        public string? ReservationCode { get; set; }
    }
}