using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("results")]
    public class SipServerGroupList : BaseApiBean
    {
        [XmlElement("sipServerGroups")]
        [XmlElement("sipServerGroup")]
        public List<SipServerGroup>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("sipservergroup")
        [XmlRoot("results")]
        public class SipServerGroupListList : BaseApiListBean<SipServerGroupList>
        {
            public override List<SipServerGroupList>? GetItems() => Items;

            public override void SetItems(List<SipServerGroupList>? value) => Items = value;
        }
    }
}