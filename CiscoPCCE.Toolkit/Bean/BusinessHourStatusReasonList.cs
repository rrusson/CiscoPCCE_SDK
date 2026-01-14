using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("results")]
    public class BusinessHourStatusReasonList : BaseApiWrappedList<BusinessHourStatusReason>
    {
        [XmlArray("businessHourStatusReasons")]
        [XmlArrayItem("businessHourStatusReason")]
        public new List<BusinessHourStatusReason>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}