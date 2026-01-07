using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("results")]
    public class BusinessHourStatusReasonList : BaseApiBean
    {
        [XmlElement("businessHourStatusReasons")]
        [XmlElement("businessHourStatusReason")]
        public List<BusinessHourStatusReason>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("businesshourstatusreason")
        [XmlRoot("results")]
        public class BusinessHourStatusReasonListList : BaseApiListBean<BusinessHourStatusReasonList>
        {
            public override List<BusinessHourStatusReasonList>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReasonList>? value) => Items = value;
        }
    }
}