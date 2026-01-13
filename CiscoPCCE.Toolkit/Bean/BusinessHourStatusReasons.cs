using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("businessHourStatusReasons")]
    public class BusinessHourStatusReasons : BaseApiBean
    {
        public List<BusinessHourStatusReason>? BusinessHourStatusReason { get; set; }
    }
}