using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("calltype")
    [XmlRoot("results")]
    public class CallTypeList : BaseApiList<CallType>
    {
        [XmlArray("callTypes")]
        [XmlArrayItem("callType")]
        public new List<CallType>? Items
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