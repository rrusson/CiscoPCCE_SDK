using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("licenseReservation")]
    public class LicenseReservationRequest : BaseApiBean
    {
        [XmlElement("reservationCode")]
        public string? ReservationCode { get; set; }
    }
}