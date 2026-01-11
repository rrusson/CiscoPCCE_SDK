using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<BusinessHourStatusReasonList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessHourStatusReasonList>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReasonList>? value) => Items = value;
        }
    }
}