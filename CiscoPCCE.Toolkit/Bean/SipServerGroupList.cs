using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("results")]
    public class SipServerGroupList : BaseApiBean
    {
        [XmlArray("sipServerGroups")]
        [XmlArrayItem("sipServerGroup")]
        public List<SipServerGroup>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("sipservergroup")
        [XmlRoot("results")]
        public class SipServerGroupListList : BaseApiListBean<SipServerGroupList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<SipServerGroupList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SipServerGroupList>? GetItems() => Items;

            public override void SetItems(List<SipServerGroupList>? value) => Items = value;
        }
    }
}