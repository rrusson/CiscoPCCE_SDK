using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("businessHourStatusReasons")]
    public class BusinessHourStatusReasons : BaseApiBean
    {
        public List<BusinessHourStatusReason>? BusinessHourStatusReason { get; set; }

        // Path("businesshourstatusreason")
        [XmlRoot("results")]
        public class BusinessHourStatusReasonsList : BaseApiListBean<BusinessHourStatusReasons>
        {
            public override List<BusinessHourStatusReasons>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReasons>? value) => Items = value;
        }
    }
}