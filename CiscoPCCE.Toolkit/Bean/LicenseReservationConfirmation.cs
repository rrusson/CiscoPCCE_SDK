using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("licenseReservation")]
    public class LicenseReservationConfirmation : BaseApiBean
    {
        [XmlElement("confirmationCode")]
        public string? ConfirmationCode { get; set; }

        [XmlElement("installReservationType")]
        public string? InstallReservationType { get; set; }
    }
}