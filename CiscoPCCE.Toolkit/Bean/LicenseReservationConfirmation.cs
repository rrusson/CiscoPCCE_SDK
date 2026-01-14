using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("licenseReservation")]
    public class LicenseReservationConfirmation : BaseApiBean
    {
        [XmlElement("confirmationCode")]
        public string? ConfirmationCode { get; set; }

        [XmlElement("installReservationType")]
        public string? InstallReservationType { get; set; }
    }
}