using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("calltype")
    [XmlRoot("results")]
    public class CallTypeList : BaseApiBean
    {
        [XmlElement("callTypes")]
        [XmlElement("callType")]
        public List<CallType>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("calltype")
        [XmlRoot("results")]
        public class CallTypeListList : BaseApiListBean<CallTypeList>
        {
            public override List<CallTypeList>? GetItems() => Items;

            public override void SetItems(List<CallTypeList>? value) => Items = value;
        }
    }
}