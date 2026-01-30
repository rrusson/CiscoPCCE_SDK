using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("results")]
    public class BusinessHourStatusReasonsList : BaseApiList<BusinessHourStatusReasons>
    {
        [XmlArray("businessHourStatusReasonss")]
        [XmlArrayItem("businessHourStatusReasons")]
        public new List<BusinessHourStatusReasons>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}