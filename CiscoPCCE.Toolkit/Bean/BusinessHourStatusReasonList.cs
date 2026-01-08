using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("results")]
    public class BusinessHourStatusReasonList : BaseApiBean
    {
        [XmlArray("businessHourStatusReasons")]
        [XmlArrayItem("businessHourStatusReason")]
        public List<BusinessHourStatusReason>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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