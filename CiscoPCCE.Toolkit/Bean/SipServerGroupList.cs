using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("results")]
    public class SipServerGroupList : BaseApiList<SipServerGroup>
    {
        [XmlArray("sipServerGroups")]
        [XmlArrayItem("sipServerGroup")]
        public new List<SipServerGroup>? Items
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