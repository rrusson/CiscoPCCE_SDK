using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("calltype")
    [XmlRoot("results")]
    public class CallTypeList : BaseApiBean
    {
        [XmlArray("callTypes")]
        [XmlArrayItem("callType")]
        public List<CallType>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("calltype")
        [XmlRoot("results")]
        public class CallTypeListList : BaseApiListBean<CallTypeList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<CallTypeList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CallTypeList>? GetItems() => Items;

            public override void SetItems(List<CallTypeList>? value) => Items = value;
        }
    }
}