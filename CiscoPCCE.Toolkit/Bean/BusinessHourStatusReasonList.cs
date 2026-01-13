using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("results")]
    public class BusinessHourStatusReasonList : BaseApiList<BusinessHourStatusReason>
    {
        [XmlArray("businessHourStatusReasons")]
        [XmlArrayItem("businessHourStatusReason")]
        public new List<BusinessHourStatusReason>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}