using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("results")]
    public class NetworkVruList : BaseApiBean
    {
        [XmlArray("networkVrus")]
        [XmlArrayItem("networkVru")]
        public List<NetworkVru>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("networkvru")
        [XmlRoot("results")]
        public class NetworkVruListList : BaseApiListBean<NetworkVruList>
        {
            public override List<NetworkVruList>? GetItems() => Items;

            public override void SetItems(List<NetworkVruList>? value) => Items = value;
        }
    }
}