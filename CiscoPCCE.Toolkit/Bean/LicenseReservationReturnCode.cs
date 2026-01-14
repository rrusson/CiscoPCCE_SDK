using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("licenseReservation")]
    public class LicenseReservationReturnCode : BaseApiBean
    {
        [XmlElement("returnReservationCode")]
        public string? ReturnReservationCode { get; set; }
    }
}